﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.Models
{
    public class ProductExtras
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int[] ExtraID { get; set; }
    }
}
