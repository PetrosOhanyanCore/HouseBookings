using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Scoring
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Rate { get;set; }
        public string? Comment { get; set; }
        public int TranslationId { get; set; }
        public Translation Translation { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int? ApartmentId { get; set; }
        public Apartment? Apartment { get; set; }

        public int? BuildingId { get; set; }
        public Building? Building { get; set; }
    }
}
