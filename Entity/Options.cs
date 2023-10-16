using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Options
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Scope { get; set; }
        public string DefaultValue { get; set; }
        public bool UserEditable { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
