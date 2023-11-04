using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RequestModel
    {
        public string Body { get; set; }
        public string QueryParams { get; set; }
        public string IPAddress { get; set; }
        public string Method { get; set; }
        public string Path { get; set; }
        public string SessionId { get; set; }
    }
}
