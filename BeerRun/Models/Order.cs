﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BeerRun.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateCompleted { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        //[Required]
        //public int DriverId { get; set; }

        //[Required]
        //public Driver Driver { get; set; }

        public int? PaymentTypeId { get; set; }

        public PaymentType PaymentType { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
