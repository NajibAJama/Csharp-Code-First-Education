using System.Data.Entity.ModelConfiguration;

namespace Csharp_Code_First_Education.Model_Configurations
{
    class DestinationConfiguration : EntityTypeConfiguration<Destination>
    {
        public DestinationConfiguration()
        {
            Property(d => d.Name).HasMaxLength(100);
            Property(d => d.Description).HasMaxLength(400);
            Property(d => d.Country).HasMaxLength(100);
            Property(d => d.Photo).HasColumnType("image");
        }
    }
}
