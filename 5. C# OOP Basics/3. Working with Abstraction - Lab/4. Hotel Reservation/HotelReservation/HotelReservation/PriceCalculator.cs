using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public class PriceCalculator
    {
        public double PricePerDay { get; set; }
        public int NumberOfDays { get; set; }
        public Season Season { get; set; }
        public Discount Discount { get; set; }

        public PriceCalculator(double pricePerDay, int numberOfDays, string season, string discount)
        {
            Season = (Season)Enum.Parse(typeof(Season), season);
            PricePerDay = pricePerDay * (int)Season;
            NumberOfDays = numberOfDays;

            if (discount != null)
            {
                Discount = (Discount)Enum.Parse(typeof(Discount), discount);
            }
        }

        public double Calculate()
        {
            double total = PricePerDay * NumberOfDays;

            if (Discount != 0)
            {
                total *= ((int)Discount / 100.0);
            }

            return total;
        }
    }
}
