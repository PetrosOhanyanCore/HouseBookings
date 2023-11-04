using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class HttpContextHelper
    {
        public static string GetClientIpAddress(HttpContext context)
        {
            string ip = null;

            var ipaddress = context.Connection.RemoteIpAddress;

            if (ipaddress != null)
                ip = ipaddress.ToString();

            return ip;
        }

        public static string DeserializeFromStream(Stream stream)
        {
            string content = "";

            using (var sr = new StreamReader(stream))
            {
                content = sr.ReadToEnd();
            }

            return content;
        }
    }
}
