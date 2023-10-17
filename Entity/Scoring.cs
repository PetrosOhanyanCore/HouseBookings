using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Scoring
    {
        public int Id { get; set; }
        public bool? IsBuilding { get; set; }
        public bool? IsApartment { get; set; }
        public bool? IsClient { get; set; }

        public DateTime Date { get; set; }
        public int? Rate { get;set; }
        public string? Comment { get; set; }
        public Translation Translation { get; set; }
    } 

}
