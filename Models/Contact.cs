using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DHSCRM.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Telephone { get; set; }
        public Customer Customer { get; set; }
    }
}
