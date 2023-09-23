using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;
using System.Linq;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;

namespace TeamBuilder.App.Core.Commands
{
    public class ShowEventCommand
    {
        public string Execute(string[] args)
        {
            Check.CheckLength(1, args);

            string eventName = args[0];

            using (TeamBuilderContext context = new TeamBuilderContext())
            {
                var teamEvent = context.Events.Include(x => x.ParticipatingEventTeams).ThenInclude(x => x.Team).
                    FirstOrDefault(x => x.Name == eventName);

                if (teamEvent == null)
                {
                    throw new ArgumentException(string.Format(Constants.ErrorMessages.EventNotFound, eventName));
                }

                return $"{eventName} {teamEvent.StartDate.ToString(Constants.DateTimeFormat, CultureInfo.InvariantCulture)} " +
                    $"{teamEvent.EndDate.ToString(Constants.DateTimeFormat, CultureInfo.InvariantCulture)}\r\n{teamEvent.Description}" +
                    $"\r\nTeams:" + (teamEvent.ParticipatingEventTeams.Any() ? 
                    $"\r\n-{string.Join("\r\n-", teamEvent.ParticipatingEventTeams.Select(x => x.Team.Name))}" : null);
            }
        }
    }
}
