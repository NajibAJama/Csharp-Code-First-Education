using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
namespace Csharp_Code_First_Education.Model_Configurations
{
    class LodginConfiguration : EntityTypeConfiguration<Lodging>
    {
        public LodginConfiguration()
        {
            Property(l => l.Name).HasMaxLength(200);
            Property(l => l.Owner).HasMaxLength(200);
            Property(l => l.MilesFromNearestAirport).HasPrecision(8, 1);

            Map<Resort>(m =>
            {
                m.ToTable("Resorts");
            });

            //used for a class with two navigation references and two inverse 
            //code first gets confused and creats four keys...but we want only two pointing
            //to each other in inverse bidrectional.

            HasOptional(l => l.PrimaryContact).WithMany(p => p.PrimaryContactFor);
            HasOptional(l => l.SecondaryContact).WithMany(p => p.SecondaryContactFor);
            
        }
    }
}
