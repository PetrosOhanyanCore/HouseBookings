using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Building
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public int Rating { get; set; }
        public string Template { get; set; }
        public int BuildingFloorQuantity { get; set; }
        public int BuildingHomeQuantity { get;set; }
        public bool isSecurity { get; set; }
        public bool isParking { get; set; }
        public bool isElevator { get; set; }

    }
}
