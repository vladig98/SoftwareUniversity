using BusTicketsSystem.Models;
using System;
using System.Globalization;

namespace BusTicketsSystem.Initializer.ModelInitializers
{
    public class ReviewsInitializer
    {
        public static Review[] GetReviews()
        {
            Review[] reviews = new Review[]
            {
                new Review() { BusCompanyId = 1, CustomerId = 1, Grade = 9.0,
                    DateAndTimeOfPublishing = DateTime.ParseExact("18/09/2023 14:10:10", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Content = "The Coach Company came to our swift aid at a very short turn around." },
                new Review() { BusCompanyId = 2, CustomerId = 2, Grade = 2.0,
                    DateAndTimeOfPublishing = DateTime.ParseExact("19/09/2023 13:06:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Content = "Having booked two mini coaches x 16 seaters to transport guests to a wedding party involving an " +
                    "hour journey, only one coach arrived." },
                new Review() { BusCompanyId = 3, CustomerId = 3, Grade = 9.9,
                    DateAndTimeOfPublishing = DateTime.ParseExact("17/09/2023 01:33:06", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Content = "Excellent Service and will most definitely use for all future events :-) Thank You to all involved!" },
                new Review() { BusCompanyId = 4, CustomerId = 4, Grade = 9.0,
                    DateAndTimeOfPublishing = DateTime.ParseExact("21/09/2023 02:22:08", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Content = "Booking with The Coach Company was really simple and the best price I could find! " +
                    "Our driver was on time for both our journeys and the coach was comfortable." },
                new Review() { BusCompanyId = 5, CustomerId = 5, Grade = 1.0,
                    DateAndTimeOfPublishing = DateTime.ParseExact("28/09/2023 14:03:45", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Content = "if I could give negative risk stars, I would left 50 young adults stranded in the middle of a field with no way home." +
                    " come to find they stole EVERYONES belongings after being told they where safe left on the buss. " +
                    "buss drive then started threatening us on what’s app. vile company don’t recommend" },
                new Review() { BusCompanyId = 6, CustomerId = 6, Grade = 9.5,
                    DateAndTimeOfPublishing = DateTime.ParseExact("30/09/2023 18:06:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Content = "Great customer service from the moment I contacted them. Very helpful staff as well as significant " +
                    "following up of our booking requirements which gave us assurance." },
                new Review() { BusCompanyId = 7, CustomerId = 7, Grade = 8.0,
                    DateAndTimeOfPublishing = DateTime.ParseExact("01/09/2023 17:01:57", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Content = "Drivers were very friendly and coach turned up early. Comfy coach with charging ports etc." },
                new Review() { BusCompanyId = 8, CustomerId = 8, Grade = 4.0,
                    DateAndTimeOfPublishing = DateTime.ParseExact("07/09/2023 12:10:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Content = "I used thecoachcompany for a trip to Goodwood. The original quote was very competitive although I was caught" +
                    " out by the fact that although the quote was regularly renewed, the price did go up a fair bit by the " +
                    "time I got to make the actual booking. " },
                new Review() { BusCompanyId = 9, CustomerId = 9, Grade = 2.0,
                    DateAndTimeOfPublishing = DateTime.ParseExact("16/09/2023 17:00:33", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Content = "Bad Customer Service Response: Coaches booked for a wedding." },
                new Review() { BusCompanyId = 10, CustomerId = 10, Grade = 3.3,
                    DateAndTimeOfPublishing = DateTime.ParseExact("15/09/2023 19:07:01", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Content = "Awful service, we requested for coaches with toilets but gave us a bus without toilets." }
            };

            return reviews;
        }
    }
}
