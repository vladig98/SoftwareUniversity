using System;
using System.Globalization;
using System.Linq;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;
using TeamBuilder.Models;

namespace TeamBuilder.App.Core.Commands
{
    public class CreateEventCommand
    {
        public string Execute(string[] args)
        {
            Check.CheckLength(6, args);

            bool startTimeValid = DateTime.TryParseExact(args[2] + " " + args[3], Constants.DateTimeFormat, CultureInfo.InvariantCulture, 
                DateTimeStyles.None, out DateTime startTime);

            bool endTimeValid = DateTime.TryParseExact(args[4] + " " + args[5], Constants.DateTimeFormat, CultureInfo.InvariantCulture,
                DateTimeStyles.None, out DateTime endTime);

            if (!startTimeValid || !endTimeValid)
            {
                throw new ArgumentException(Constants.ErrorMessages.InvalidDateFormat);
            }

            if (startTime.CompareTo(endTime) > 1)
            {
                throw new ArgumentException("Start date should be before end date.");
            }

            if (!AuthenticationManager.IsAuthenticated())
            {
                throw new InvalidOperationException(Constants.ErrorMessages.LoginFirst);
            }

            User currentUser = AuthenticationManager.GetCurrentUser();

            string name = args[0];
            string description = args[1];

            using (TeamBuilderContext context = new TeamBuilderContext())
            {
                currentUser = context.Users.FirstOrDefault(x => x == currentUser);

                var eventFromDb = context.Events.FirstOrDefault(x => x.Name == name);

                Event userEvent = new Event
                {
                    CreatorId = currentUser.Id,
                    Description = description,
                    EndDate = endTime,
                    Name = name,
                    StartDate = startTime,
                };

                if (eventFromDb != null)
                {
                    if (eventFromDb.StartDate.CompareTo(userEvent.StartDate) < 1)
                    {
                        eventFromDb.StartDate = userEvent.StartDate;
                        eventFromDb.EndDate = userEvent.EndDate;
                        eventFromDb.Description = userEvent.Description;
                        context.SaveChanges();
                    }
                }
                else
                {
                    context.Events.Add(userEvent);
                    context.SaveChanges();
                }
            }

            return $"Event {name} was created successfully!";
        }
    }
}
