using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DHSCRM.Models
{
    public class Job
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public string PostcodeFrom { get; set; }
        public string PostcodeTo { get; set; }
        public int TotalMiles { get; set; }
        public Customer Customer { get; set; }
    }
}
