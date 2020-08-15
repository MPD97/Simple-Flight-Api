using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Domain.Entities
{
    public class Flight
    {
        public long FlightId { get; set; }

        public long PlaneId { get; set; }
        public virtual Plane Plane { get; set; }

        public long FlightLineId { get; set; }
        public virtual FlightLine FlightLine { get; set; }

        public long FlightDepartId { get; set; }
        public virtual FlightShedule FlightDepart { get; set; }

        public virtual ICollection<FlightTicket> FlightTickets { get; set; }
    }
}
