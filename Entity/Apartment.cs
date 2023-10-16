using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Apartment
    {
        public int Id { get; set; }
        public Translation Translation { get; set; }
        public decimal Price { get; set; }
        public int RoomsCount { get; set; }
        public int Bathrooms { get; set; }
        public double SquareMeter { get; set; }
        public Address Location { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime LastUpdated { get; set; }


        public int BuildingId { get; set; }
        public Building Building { get; set; }
        public string Section { get; set; }
        public string Number { get; set; }

        public int? Floor { get; set; }
        public int? FloorCount { get; set; }
        public double? FloorHeight { get; set; }
        public bool? IsParkingSpaceExist { get; set; }
        public bool? IsPentHouse { get; set; }
        public bool? IsStudio { get; set; }
        public bool? IsTownHouse { get; set; }
        public double? LivingRoomArea { get; set; }
        public double? KitchenArea { get; set; }
        public bool IsKitchenAttached { get; set; }
        public int BalconyCount { get; set; }

        public ICollection<Image> Images { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
