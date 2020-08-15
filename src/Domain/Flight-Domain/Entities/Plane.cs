using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Domain.Entities
{
    public class Plane
    {
        public long PlaneId { get; set; }

        public short PlaneModelId { get; set; }
        public virtual PlaneModel PlaneModel { get; set; }

        public virtual ICollection<PassengerSeat> AvailableSeats { get; set; }
    }
}
