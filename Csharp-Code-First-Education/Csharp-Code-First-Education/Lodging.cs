namespace Csharp_Code_First_Education
{
    class Lodging
    {
        public int LodgingId { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public bool IsResort { get; set; }
        public Destination DestinationId { get; set; }
        public decimal MilesFromNearestAirport { get; set; }
    }
}
