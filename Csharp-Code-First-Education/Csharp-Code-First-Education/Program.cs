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
            //InsertPerson();
            ////UpdatePerson();
            //UpdateTrip();
            //DeleteDestinationInMemoryAndDbCascade();
            DisplyDestination();
            //InsertLodging();
            
            InsertResort();
            InsertLodging();
            Console.ReadLine();


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
            //Console.ReadLine();
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
                SocialSecurityNumber = 123999999,
                Photo = new PersonPhoto
                {
                    Photo = new byte[] { 0 }
                }
            };
            using (var context = new BreakAwayContext())
            {
                context.People.Add(person);
                context.SaveChanges();
                Console.WriteLine("person added");
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
                var person = context.People.Include("Photo").FirstOrDefault();
                person.FirstName = "Rowena";
                if (person.Photo == null)
                {
                    person.Photo = new PersonPhoto { Photo = new Byte[] { 0 } };
                }
            }
        }
       
        private static void DeleteDestinationInMemoryAndDbCascade()
        {
            int destinationId;
            using (var context = new BreakAwayContext())
            {
                var destination = new Destination
                {
                    Name = "Sample Destination",
                    Lodgings = new List<Lodging>{
                        new Lodging { Name = "Lodging One" },
                        new Lodging { Name = "Lodging Two" }
                    }
                };

                context.Destinations.Add(destination);
                context.SaveChanges();
                destinationId = destination.DestinationId;
                Console.WriteLine("the sample destination id = " + destinationId);
            }

            using (var context = new BreakAwayContext())
            {
                var destination = context.Destinations
                .Include(d => d.Lodgings)
                .Single(d => d.DestinationId == destinationId);

                var aLodging = destination.Lodgings.FirstOrDefault();
                context.Destinations.Remove(destination);
                Console.WriteLine("State of one Lodging: {0}",
                context.Entry(aLodging).State.ToString());
                context.SaveChanges();
            }
        }

        private static void InsertLodging()
        {
            var lodging = new Lodging
            {
                Name = "Rainy Day Motel",
                Destination = new Destination
                {
                    Name = "Seattle, Washington",
                    Country = "USA"
                }
            };
            using (var context = new BreakAwayContext())
            {
                context.Lodgings.Add(lodging);
                context.SaveChanges();
            }
        }

        private static void InsertResort()
        {
            var resort = new Resort
            {
                Name = "Top Notch Resort and Spa",
                MilesFromNearestAirport = 30,
                Activities = "Spa, Hiking, Skiing, Ballooning",
                Destination = new Destination
                {
                    Name = "Stowe, Vermont",
                    Country = "USA"
                }
            };
            using (var context = new BreakAwayContext())
            {
                context.Lodgings.Add(resort);
                context.SaveChanges();
            }
        }




    }
}
