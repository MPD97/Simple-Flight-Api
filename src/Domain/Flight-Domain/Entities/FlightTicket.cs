using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Domain.Entities
{
    public class FlightTicket
    {
        public long FlightTicketId { get; set; }

        public decimal Price { get; set; }
        public int Discount { get; set; }

        public long PassengerId { get; set; }
        public virtual Person Passenger { get; set; }

        public long SeatId { get; set; }
        public virtual PassengerSeat Seat { get; set; }

        public long FlightId { get; set; }
        public virtual Flight Flight { get; set; }

    }
}
