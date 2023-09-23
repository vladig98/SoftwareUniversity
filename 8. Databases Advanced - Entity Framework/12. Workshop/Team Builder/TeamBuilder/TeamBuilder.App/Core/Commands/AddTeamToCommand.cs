using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;
using TeamBuilder.Models;

namespace TeamBuilder.App.Core.Commands
{
    public class AddTeamToCommand
    {
        public string Execute(string[] args)
        {
            Check.CheckLength(2, args);

            string eventName = args[0];
            string teamName = args[1];

            if (!AuthenticationManager.IsAuthenticated())
            {
                throw new InvalidOperationException(Constants.ErrorMessages.LoginFirst);
            }

            var currentUser = AuthenticationManager.GetCurrentUser();

            using (TeamBuilderContext context = new TeamBuilderContext())
            {
                Event teamEvent = context.Events.Include(x => x.ParticipatingEventTeams).ThenInclude(x => x.Team)
                    .Include(x => x.Creator)
                    .FirstOrDefault(x => x.Name == eventName);

                if (teamEvent == null)
                {
                    throw new ArgumentException(string.Format(Constants.ErrorMessages.EventNotFound, eventName));
                }

                Team team = context.Teams.FirstOrDefault(x => x.Name == teamName);

                if (team == null)
                {
                    throw new ArgumentException(string.Format(Constants.ErrorMessages.TeamNotFound, teamName));
                }

                if (teamEvent.CreatorId != currentUser.Id)
                {
                    throw new InvalidOperationException(Constants.ErrorMessages.NotAllowed);
                }

                if (teamEvent.ParticipatingEventTeams.Any(x => x.TeamId == team.Id))
                {
                    throw new InvalidOperationException(Constants.ErrorMessages.CannotAddSameTeamTwice);
                }

                TeamEvent teamEventToInsert = new TeamEvent
                {
                    EventId = teamEvent.Id,
                    TeamId = team.Id
                };

                context.TeamEvents.Add(teamEventToInsert);
                context.SaveChanges();
            }

            return $"Team {teamName} added to {eventName}!";
        }
    }
}
