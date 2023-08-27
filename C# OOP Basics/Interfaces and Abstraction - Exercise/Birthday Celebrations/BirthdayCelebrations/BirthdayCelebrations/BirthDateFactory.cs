using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BirthdayCelebrations
{
    public class BirthDateFactory
    {
        public string year { get; private set; }

        public BirthDateFactory(string year)
        {
            this.year = year;
        }

        public bool DoBirthDatesMatch(IBirthDataAble citizen)
        {
            DateTime date = DateTime.ParseExact(citizen.birthDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            return date.Year.ToString() == this.year;
        }
    }
}
