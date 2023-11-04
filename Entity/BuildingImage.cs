using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class BuildingImage
    {
        public int Id { get; set; }
        public string ImageName { get; set; }

        public Building Building { get; set; }

        public int BuildingId { get; set; }
    }
}
