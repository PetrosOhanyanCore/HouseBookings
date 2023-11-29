using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.DTO
{
    public class BuildingDTO
    {

        public int Id { get; set; }

        public AddressDTO Location { get; set; }
        public int Rating { get; set; }
        public string Template { get; set; }
        public int BuildingFloorQuantity { get; set; }
        public int BuildingHomeQuantity { get; set; }
        public bool HasSecurity { get; set; }
        public bool HasParking { get; set; }
        public bool HasElevator { get; set; }
        public double? ApartmentSquareMin { get; set; }
        public double? ApartmentSquareMax { get; set; }

        public TranslationDTO Translation { get; set; }
        public IEnumerable<ApartmentDTO> Apartments { get; set; }
        public ICollection<OptionsDTO> Options { get; set; }
        public ICollection<ScoringDTO> Scorings { get; set; }

    }
}
