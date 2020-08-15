using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Domain.Entities
{
    public class PassengerSeat
    {
        public long PassengerSeatId { get; set; }
        public SeatType SeatType { get; set; }
        public byte Row { get; set; }
        public byte Column { get; set; }

        public long PlaneId { get; set; }
        public virtual Plane Plane { get; set; }

        public virtual ICollection<FlightTicket> SoldTickets { get; set; }
    }
    public enum SeatType
    {
        Standard,
        Premium,
        StandardBed,
        PremiumBed,
    }
}
