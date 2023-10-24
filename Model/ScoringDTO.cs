using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Model
{
    public class ScoringDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Rate { get; set; }
        public string? Comment { get; set; }
        public TranslationDTO Translation { get; set; }

        public ClientDTO Client { get; set; }

        public ApartmentDTO? Apartment { get; set; }

        public BuildingDTO? Building { get; set; }
    }
}
