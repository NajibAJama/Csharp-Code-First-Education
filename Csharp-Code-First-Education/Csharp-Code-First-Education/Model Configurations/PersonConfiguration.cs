using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
namespace Csharp_Code_First_Education.Model_Configurations
{
    class PersonConfiguration:EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            //HasKey(p => p.SocialSecurityNumber);
            //Property(p => p.SocialSecurityNumber).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.RowVersion).IsRowVersion();
            //Property(p => p.SocialSecurityNumber).IsConcurrencyToken(true);
            ToTable("People");
        }
    }
}
