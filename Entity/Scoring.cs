using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Scoring
    {
        public int BuildingId { get; set; }
        public int PenthousId { get; set; }
        public int TownhousId { get; set; }
        public int ApartmentId { get; set; }
        public int ClientId { get; set; }

        public DateTime date { get; set; }
        public string Comment { get; set; }


    }
 
}
