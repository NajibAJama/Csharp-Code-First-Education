
using Csharp_Code_First_Education.Model_Configurations;
using System.Data.Entity;

namespace Csharp_Code_First_Education
{
    class BreakAwayContext : DbContext
    {
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
        public DbSet<Trip> Trips { get; set; }
        //public DbSet<Person> People { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DestinationConfiguration());
            modelBuilder.Configurations.Add(new LodginConfiguration());
            modelBuilder.Configurations.Add(new TripConfiguration());
        }
    }
}
