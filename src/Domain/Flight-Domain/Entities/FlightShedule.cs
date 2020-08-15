using System;

namespace Flight_Domain.Entities
{
    public class FlightShedule
    {
        public long FlightSheduleId { get; set; }
        public DateTime DepartTime { get; set; }

        public long FlightLineId { get; set; }
        public virtual FlightLine FlightLine { get; set; }

        public long FlightId { get; set; }
        public virtual Flight Flight { get; set; }
    }
}