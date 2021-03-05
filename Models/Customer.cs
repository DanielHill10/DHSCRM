using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DHSCRM.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string AddressStreet { get; set; }
        public string AddressTown { get; set; }
        public string AddressCounty { get; set; }
        public string AddressPostCode { get; set; }
        public string EmailAddress { get; set; }
        public string Telephone { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public ICollection<Job> Jobs { get; set; }

    }
}
