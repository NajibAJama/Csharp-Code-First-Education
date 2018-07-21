using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace Csharp_Code_First_Education
{
    class Destination
    {
        public int DestinationId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }
        public List<Lodging> Lodgings { get; set; }
        private string _todayForecast;
        public string TodayForecast
        {
            get { return _todayForecast; }
            set { _todayForecast = value; }
        }

    }
}
