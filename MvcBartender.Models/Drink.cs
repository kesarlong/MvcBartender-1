﻿using System.ComponentModel.DataAnnotations;

namespace MvcBartender.Models
{
    public class Drink
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
