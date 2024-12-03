﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchMarkPerformanceAnalysis.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; } // Primary key

        [Required]
        public string Name { get; set; } // Product name

        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; } // Product price
    }
}
