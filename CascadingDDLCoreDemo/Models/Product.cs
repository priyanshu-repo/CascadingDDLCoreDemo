﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace CascadingDDLCoreDemo.Models
{
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public virtual Category Category { get; set; }
    }
}
