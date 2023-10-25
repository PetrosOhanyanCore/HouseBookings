using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ApartmentImage
    {
        public int Id { get; set; }
        public string ImageName { get; set; }

        public Apartment Apartment { get; set; }
        public int ApartmentId { get; set; }
    }
}