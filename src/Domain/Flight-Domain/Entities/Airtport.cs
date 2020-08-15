using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Domain.Entities
{
    public class Airtport
    {
        public int AirportId { get; set; }
        
        public int CityId { get; set; }
        public virtual City City { get; set; }
        
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
