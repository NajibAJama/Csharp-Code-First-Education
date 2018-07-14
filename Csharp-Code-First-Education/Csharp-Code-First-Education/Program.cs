using System.Data.Entity;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Csharp_Code_First_Education
{
    class Program
    {
        static void Main(string[] args)
        {
           Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BreakAwayContext>());
            //InsirtIntoDestination();
            //InsertTrip();
            InsertPerson();
            //UpdatePerson();
            //UpdateTrip();
            //DisplyDestination();
        }
        private static void InsirtIntoDestination()
        {
            Destination destination = new Destination
            {
                Country = "Indonesia",
                Name = "Bali",
                Description = "old bali cultural resort",
            };

            using (BreakAwayContext context = new BreakAwayContext())
            {
                context.Destinations.Add(destination);
                context.SaveChanges();
            }
        }

        private static void DisplyDestination()
        {
            List<Destination> destinations = new List<Destination>();
            using (BreakAwayContext context = new BreakAwayContext())
            {
                foreach (Destination d in context.Destinations)
                {
                    destinations.Add(d);
                }
            }
            foreach (Destination d in destinations)
            {
                Console.WriteLine(d.Country);
                Console.WriteLine(d.Name);
                Console.WriteLine(d.Description);
                Console.WriteLine(d.DestinationId);
            }
            Console.ReadLine();
        }

        private static void InsertTrip()
        {
            Trip trip = new Trip()
            {
                CostUSD = 800,
                StartDate = new DateTime(2011, 9, 1),
                EndDate = new DateTime(2011, 9, 14)
            };
            using (BreakAwayContext context = new BreakAwayContext())
            {
                context.Trips.Add(trip);
                context.SaveChanges();
            }
        }

        private static void InsertPerson()
        {
            var person = new Person
            {
                FirstName = "Rowan",
                LastName = "Miller",
                SocialSecurityNumber = 123999999
            };
            using (var context = new BreakAwayContext())
            {
                context.People.Add(person);
                context.SaveChanges();
            }
        }

        private static void UpdateTrip()
        {
            using (var context = new BreakAwayContext())
            {
                var trip = context.Trips.FirstOrDefault();
                trip.CostUSD = 50;
                context.SaveChanges();
            }
            Console.WriteLine("trip updated");
        }

        private static void UpdatePerson()
        {
            using (var context = new BreakAwayContext())
            {
                var person = context.People.FirstOrDefault();
                person.FirstName = "Rowena";
                context.SaveChanges();
            }
        }
    }
}
