using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Code_First_Education
{
    [NotMapped]
    class Reservation
    {
        public int ReservationId { get; set; }
        public DateTime DateTimeMade { get; set; }
        public Person Traveler { get; set; }
        public Trip Trip { get; set; }
        public DateTime PaidInFull { get; set; }
    }
}
