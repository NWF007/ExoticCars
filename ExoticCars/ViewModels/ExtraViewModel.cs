using ExoticCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.ViewModels
{
    public class ExtraViewModel
    {
        public IEnumerable<Extra> Extras { get; set; }
        public Extra Extra { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public ProductExtras ProductExtra { get; set; }
    }
}
