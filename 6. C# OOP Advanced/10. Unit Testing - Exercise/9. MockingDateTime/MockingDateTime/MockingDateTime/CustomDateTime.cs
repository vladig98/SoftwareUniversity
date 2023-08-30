using System;
using System.Collections.Generic;
using System.Text;

namespace MockingDateTime
{
    public class CustomDateTime
    {
        private readonly ICustomDateTime customDateTime;
        private DateTime Date;

        public CustomDateTime(ICustomDateTime customDateTime, DateTime? date)
        {
            this.customDateTime = customDateTime;
            Date = (DateTime)(date == null ? DateTime.Now : date);
        }

        public DateTime AddDays(double days)
        {
            Date = Date.AddDays(days);
            return Date;
        }
    }
}
