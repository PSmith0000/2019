﻿using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace Brutus.Utils
{
    internal class Network
    {
        internal static bool IsHostUp(string URL)
        {
            Ping pingRequest = new Ping();
            string CleanURL = Regex.Replace(URL, @"h\w*:..", "");
            CleanURL = CleanURL.Remove(CleanURL.IndexOf('/'));
            var address = Dns.GetHostEntry(CleanURL).AddressList.First();
            var reply = pingRequest.Send(address);
            if (reply.Status == IPStatus.Success)
            {
                return true;
            }
            return false;
        }
    }
}