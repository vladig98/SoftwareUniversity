using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public int CalculateDifferenceBetweenDates(string date1, string date2)
        {
            DateTime dateTime1 = DateTime.Parse(date1);
            DateTime dateTime2 = DateTime.Parse(date2);

            return Math.Abs((int)Math.Floor((dateTime2 - dateTime1).TotalDays));
        }
    }
}
