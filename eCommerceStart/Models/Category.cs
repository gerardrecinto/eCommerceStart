﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eCommerceStart.Models
{
    public class Category
    {
        public Category()
        {
        }
        public int Id { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Category name is required")]
        [MaxLength(45,ErrorMessage = "The category name can be maximum 45 characters long")]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; } 
    }
}
