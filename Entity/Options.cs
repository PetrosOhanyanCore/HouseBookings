using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Options
    {

        public int Id { get; set; }
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
        public int BuildingId { get; set; }
        public Building Building { get; set; }
        public string Discription { get; set; }
    }
}
