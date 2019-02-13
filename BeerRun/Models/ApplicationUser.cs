using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeerRun.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {

        }

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
        [Display(Name = "Address")]
        public string StreetAddress { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<PaymentType> PaymentTypes { get; set; }

        public bool? IsActive { get; set; }
    }
}