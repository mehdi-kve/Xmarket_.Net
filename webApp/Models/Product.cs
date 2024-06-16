﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Category")]

        public int? CategoryId { get; set; }

        public Category? Category { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int? Quantity { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public double? Price { get; set; }

    }
}
