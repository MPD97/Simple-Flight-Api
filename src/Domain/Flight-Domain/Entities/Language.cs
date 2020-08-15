using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Domain.Entities
{
    public class Language
    {
        public short LanguageId { get; set; }
        public string LanguageName { get; set; }

        public virtual ICollection<Country> UsedInCountries { get; set; }
    }
}
