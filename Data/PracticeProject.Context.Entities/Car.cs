﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Context.Entities
{
    public class Car : BaseEntity
    {
//        [Key]
        public int CarId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [Range(1900, 2100)]
        public int? Year { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        [MaxLength(20)]
        public string? Color { get; set; }

        public int? SellerId { get; set; }
        public virtual User Seller { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DatePosted { get; set; }
        public virtual ICollection<ViewingRequest>? ViewingRequestsCar { get; set; }
    }
}