﻿using System.ComponentModel.DataAnnotations;

namespace LojaMicro.Web.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public long Stock { get; set; }

        [Range(1, 100)]
        public int Quantity { get; set; } = 1;

        [Required]
        public string? ImageURL { get; set; }

        public string? CategoryName { get; set; }

        public int CategoryId { get; set; }
    }
}
