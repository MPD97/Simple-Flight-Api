using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Flight_Domain.Entities
{
    public class PlaneModel
    {
        public short PlaneModelId { get; set; }
        public string Role { get; set; }
        public string Manufacturer { get; set; }
        public short Crew { get; set; }
        public short Capacity { get; set; }
        public short LuggageCapacity { get; set; }

        public virtual ICollection<Plane> Planes { get; set; }

    }
}
