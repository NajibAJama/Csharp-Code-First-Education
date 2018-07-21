using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csharp_Code_First_Education
{
    [Table("People")]
    class PersonPhoto
    {
        public int PersonId { get; set; }
        public byte[] Photo { get; set; }
        public string Caption { get; set; }
        public Person PhotoOf { get; set; }
    }
}
