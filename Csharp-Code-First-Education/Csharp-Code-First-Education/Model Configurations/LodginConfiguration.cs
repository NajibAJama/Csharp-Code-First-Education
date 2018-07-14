using System.Data.Entity.ModelConfiguration;

namespace Csharp_Code_First_Education.Model_Configurations
{
    class LodginConfiguration : EntityTypeConfiguration<Lodging>
    {
        public LodginConfiguration()
        {
            Property(l => l.Name).HasMaxLength(200);
            Property(l => l.Owner).HasMaxLength(200);
            Property(l => l.MilesFromNearestAirport).HasPrecision(8, 1);
        }
    }
}
