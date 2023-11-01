using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ErrorLog
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public string Reason { get; set; }
        public string StackTrace { get; set; }
    }
}
