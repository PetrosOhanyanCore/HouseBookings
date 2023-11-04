using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ErrorResponse
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public int Reason { get; set; }
    }
}
