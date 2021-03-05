using DHSCRM.Data;
using DHSCRM.Models;
using System;
using System.Linq;

namespace DHSCRM.Data
{
    public static class DbInitializer
    {
        public static void Initialize(RecordDetailContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Customers.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
                new Customer{CustomerId=1, CustomerName="The Access Group",AddressPostCode="LE67 2NY", EmailAddress="test@test.com"},
                new Customer{CustomerId=2, CustomerName="PHTS",AddressPostCode="LE67 6NB", EmailAddress="test2@test.com"},
                new Customer{CustomerId=3, CustomerName="Dill's Delights",AddressPostCode="DE24 1AB", EmailAddress="test3@test.com"}
            };
            foreach (Customer s in customers)
            {
                context.Customers.Add(s);
            }
            context.SaveChanges();

            if(context.Contacts.Any())
            {
                return; //Db has been seeded
            }

            var contacts = new Contact[]
            {
                new Contact{ContactId=1, FirstName="John", LastName="Dorian", EmailAddress="test@test.com"},
                new Contact{ContactId=2, FirstName="Turk", LastName="Turkleton", EmailAddress="test1@test.com"},
                new Contact{ContactId=3, FirstName="Elliot", LastName="Reid", EmailAddress="test3@test.com"},
            };
            foreach (Contact c in contacts)
            {
                context.Contacts.Add(c);
            }
            context.SaveChanges();

            if (context.Contacts.Any())
            {
                return; //Db has been seeded
            }

            var jobs = new Job[]
            {
                new Job{JobId=1,JobName="First Job",TotalMiles=5},
                new Job{JobId=2,JobName="Second Job",TotalMiles=10},
                new Job{JobId=3,JobName="Third Job",TotalMiles=15},
            };
            foreach (Job j in jobs)
            {
                context.Jobs.Add(j);
            }
            context.SaveChanges();
        }
    }
}