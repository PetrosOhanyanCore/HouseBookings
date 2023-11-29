using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class ApartmentImageDTO
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public int ApartmentId { get; set; }
        public ApartmentDTO ApartmentDTO { get; set; }

    }
}
