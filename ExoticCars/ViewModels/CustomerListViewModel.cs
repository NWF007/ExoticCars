﻿using ExoticCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.ViewModels
{
    public class CustomerListViewModel
    {
        public IEnumerable<Customer> Customers { get; set; }
    }
}
