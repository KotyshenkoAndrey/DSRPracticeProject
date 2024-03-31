﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Context.Entities
{
    public class ViewingRequest : BaseEntity
    {
//        [Key]
        public int ViewingRequestId { get; set; }

        [Required]
        public int CarId { get; set; }
        public virtual Car Car { get; set; }

        [Required]
        public int SellerId { get; set; }
        public virtual User Seller { get; set; }

        public bool IsConfirmed { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime RequestDate { get; set; }
    }
}