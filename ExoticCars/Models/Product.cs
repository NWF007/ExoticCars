﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace ExoticCars.Models
{
    public class Product
    {
        [BindNever]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Please enter car name")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter car model")]
        [StringLength(50)]
        public string Model { get; set; }

        [Required(ErrorMessage = "Please enter car selling price")]
        [StringLength(50)]
        public int SellingPrice { get; set; }

        [Required(ErrorMessage = "Please enter car cost price")]
        [StringLength(50)]
        public int CostPrice { get; set; }

        [Required(ErrorMessage = "Please enter car year")]
        [StringLength(50)]
        public string Year { get; set; }

        [Required(ErrorMessage = "Please enter car engine number")]
        [StringLength(50)]
        public string EngineNo { get; set; }
    }
}