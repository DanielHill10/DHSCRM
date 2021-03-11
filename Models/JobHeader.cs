using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DHSCRM.Models
{
    public class JobHeader
    {
        public int JobHeaderId { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}
