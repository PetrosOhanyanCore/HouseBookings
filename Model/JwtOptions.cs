using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class JwtOptions
    {
        public string Key { get; set; }
        public int ExpiryMinutes { get; set; }
        public string Issuer { get; set; }
        public bool ValidateLifetime { get; set; }
    }
}
