
using System.Data.Entity.ModelConfiguration;

namespace Csharp_Code_First_Education.Model_Configurations
{
    class AddressConfiguration :
ComplexTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {
            Property(a => a.StreetAddress).HasMaxLength(150);
            Property(a => a.StreetAddress).HasColumnName("StreetAddress");
            Property(a => a.City).HasColumnName("City");
            Property(a => a.State).HasColumnName("State");
            Property(a => a.ZipCode).HasColumnName("ZipCode");

        }
    }
}
