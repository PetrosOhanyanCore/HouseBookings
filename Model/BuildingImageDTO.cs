﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Model
{
    public class BuildingImageDTO
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public BuildingDTO Building { get; set; }
    }
}
