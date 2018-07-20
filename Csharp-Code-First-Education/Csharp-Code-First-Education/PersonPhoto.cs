using System.ComponentModel.DataAnnotations;

namespace Csharp_Code_First_Education
{
    class PersonPhoto
    {
        [Key]
        public int PersonId { get; set; }
        public byte[] Photo { get; set; }
        public string Caption { get; set; }
        public Person PhotoOf { get; set; }
    }
}
