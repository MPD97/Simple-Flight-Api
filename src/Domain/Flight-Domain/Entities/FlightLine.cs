using System.Collections;
using System.Collections.Generic;

namespace Flight_Domain.Entities
{
    public class FlightLine
    {
        public long FlightLineId { get; set; }

        public int FlightTimeMinutes { get; set; }
        public decimal PricePerKM { get; set; }
        public short EstimatedDistance { get; set; }

        public int SourceAirportId { get; set; }
        public virtual Airtport SourceAirport { get; set; }

        public int DestinationAirportId { get; set; }
        public virtual Airtport DestinationAirport { get; set; }

        public virtual ICollection<FlightShedule> FlightShedules { get; set; }
    }
}
