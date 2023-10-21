using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Building
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public Address Location { get; set; }
        public int Rating { get; set; }
        public string Template { get; set; }
        public int BuildingFloorQuantity { get; set; }
        public int BuildingHomeQuantity { get; set; }
        public bool HasSecurity { get; set; }
        public bool HasParking { get; set; }
        public bool HasElevator { get; set; }

        public double? ApartmentSquareMin { get; set; }
        public double? ApartmentSquareMax { get; set; }

        public Translation Translation { get; set; }

        public ICollection<Image> Images { get; set; }
        public IEnumerable<Apartment> Apartments { get; set; }
        public ICollection<Options> Options { get; set; }
        public ICollection<Scoring> Scorings { get; set; }

    }
}
