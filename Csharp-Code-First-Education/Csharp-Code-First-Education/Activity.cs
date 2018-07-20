using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Csharp_Code_First_Education
{
    class Activity
    {
        public int ActivityId { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        public List<Trip> Trips { get; set; }
    }
}
