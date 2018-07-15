using System.Data.Entity.ModelConfiguration;

namespace Csharp_Code_First_Education.Model_Configurations
{
    class InternetSpecialConfiguration:EntityTypeConfiguration<InternetSpecial>
    {
        public InternetSpecialConfiguration()
        {
            HasRequired(s => s.Accommodation).WithMany(l => l.InternetSpecials).HasForeignKey(s => s.AccommodationId);
            
        }
    }
}
