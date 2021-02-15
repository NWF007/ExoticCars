using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.Models
{
    public class Extra
    {
        
        public int ExtraID { get; set; }

        [Required(ErrorMessage = "Please enter extra name")]
        [StringLength(50)]
        public string ExtraName { get; set; }

        [Required(ErrorMessage = "Please enter extra price")]
        [StringLength(50)]
        public decimal ExtraPrice { get; set; }
    }
}
