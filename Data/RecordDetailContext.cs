using DHSCRM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DHSCRM.Data
{
    public class RecordDetailContext : DbContext
    {
        public RecordDetailContext(DbContextOptions<RecordDetailContext> options) : base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<DHSCRM.Models.JobHeader> JobHeader { get; set; }
    }
}
