using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Domain.Entities
{
    public class Person
    {
        public long PersonId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }


        public int NationalityId { get; set; }
        public virtual Country Nationality { get; set; }

    }
}
