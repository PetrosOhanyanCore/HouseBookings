﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Options
    {
        public int Id { get ; set; }
        public int ApartmentId { get; set; }
        public virtual Apartment Apartment { get; set; }
        public string Discription { get; set; }
    }
}
