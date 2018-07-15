
using Csharp_Code_First_Education.Model_Configurations;
using System.Data.Entity;

namespace Csharp_Code_First_Education
{
    class BreakAwayContext : DbContext
    {
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Person> People { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DestinationConfiguration());
            modelBuilder.Configurations.Add(new LodginConfiguration());
            modelBuilder.Configurations.Add(new TripConfiguration());
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new AddressConfiguration());
            //Specifying Unconventionally Named Foreign Keys
            modelBuilder.Configurations.Add(new InternetSpecialConfiguration());

            //complexType config must come after inline Configurations:
            //address has a key and model builder should know it's a complextype even if it has a primarykey
            modelBuilder.ComplexType<Address>();
            //complex type configuration for personalinfo class:
            modelBuilder.ComplexType<PersonalInfo>();


        }
    }
}
