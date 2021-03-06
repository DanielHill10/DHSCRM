using DHSCRM.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DHSCRM.ViewModels
{
    public class ContactDetailViewModel
    {
        public Contact Contact { get; set; }
        public Customer Customer { get; set; }
        public List<SelectListItem> Customers { get; set; }
    }
}
