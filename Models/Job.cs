using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DHSCRM.Models
{
    public class Job
    {
        public int JobId { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string JobName { get; set; }
        [Display(Name = "Description")]
        public string JobDescription { get; set; }
        [Display(Name = "Postcode From")]
        public string PostcodeFrom { get; set; }
        [Display(Name = "Postcode To")]
        public string PostcodeTo { get; set; }
        [Display(Name = "Mileage")]
        public int TotalMiles { get; set; }
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
