using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Domain.Entities
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public long Population { get; set; }

        public short LanguageId { get; set; }
        public virtual Language Language { get; set; }

        public virtual ICollection<Person> PersonNationalities { get; set; }
        public virtual ICollection<Airtport> Airtports { get; set; }
    }
}
