using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ImageDTO
    {
        public int Id { get; set; }
        public string ImageName { get; set; }

        public ApartmentDTO ApartmentDTO { get; set; }
        //public BuildingDTO BuildingDTO { get; set; }
    }
}
