﻿using System.ComponentModel.DataAnnotations;

namespace ProductManagementApp.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string? ProductName { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
