using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeerRun.Models
{
    public class ProductLocation
    {
        [Key]
        public int ProductLocationId { get; set; }

        [Required]
        public int ProductId { get; set; }

        public Product Product { get; set; }

        [Required]
        public int LocationId { get; set; }

        public Location Location { get; set; }
    }
}
