using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DHSCRM.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        [Display(Name = "Customer Name")]
        public string? CustomerName { get; set; }
        [Display(Name = "Street")]
        public string AddressStreet { get; set; }
        [Display(Name = "Town")]
        public string AddressTown { get; set; }
        [Display(Name = "County")]
        public string AddressCounty { get; set; }
        [Display(Name = "Post Code")]
        public string AddressPostCode { get; set; }
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        public string Telephone { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public ICollection<Job> Jobs { get; set; }

    }
}
