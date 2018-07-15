using System;
namespace Csharp_Code_First_Education
{
    class InternetSpecial
    {
        public int InternetSpecialId { get; set; }
        public int Nights { get; set; }
        public decimal CostUSD { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int AccommodationId { get; set; }
        public Lodging Accommodation { get; set; }
    }
}
