using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeerRun.Models
{
    public class Driver
    {
        [Key]
        public int DriverId { get; set; }
        
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        [Required]
        public int Age { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        public string Vehicle { get; set; }

        public bool? IsOnDelivery { get; set; }
    }
}
