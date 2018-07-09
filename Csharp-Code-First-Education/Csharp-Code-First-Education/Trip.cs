using System;

namespace Csharp_Code_First_Education
{
    class Trip
    {
        public Guid Identifier { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal CostUSD { get; set; }
    }
}
