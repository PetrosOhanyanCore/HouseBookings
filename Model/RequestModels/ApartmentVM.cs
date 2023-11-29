﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.RequestModels
{
    public class ApartmentVM
    {
        public decimal Price { get; set; }
        public int RoomsCount { get; set; }
        public int Bathrooms { get; set; }
        public double SquareMeter { get; set; }
        public int LocationId { get; set; }
        public bool IsAvailable { get; set; }


        public int BuildingId { get; set; }
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
    }
}
