using System.Linq;
using System;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;
using TeamBuilder.Models;
using Microsoft.EntityFrameworkCore;

namespace TeamBuilder.App.Core.Commands
{
    public class DeclineInviteCommand
    {
        public string Execute(string[] args)
        {
            Check.CheckLength(1, args);

            string teamName = args[0];

            if (!AuthenticationManager.IsAuthenticated())
            {
                throw new InvalidOperationException(Constants.ErrorMessages.LoginFirst);
            }

            var currentUser = AuthenticationManager.GetCurrentUser();

            using (TeamBuilderContext context = new TeamBuilderContext())
            {
                Team team = context.Teams.FirstOrDefault(x => x.Name == teamName);

                if (team == null)
                {
                    throw new ArgumentException(string.Format(Constants.ErrorMessages.TeamNotFound, teamName));
                }

                currentUser = context.Users.Include(x => x.ReceivedInvitations).ThenInclude(x => x.Team).FirstOrDefault(x => x == currentUser);

                if (!currentUser.ReceivedInvitations.Any(x => x.TeamId == team.Id && x.IsActive))
                {
                    throw new ArgumentException(string.Format(Constants.ErrorMessages.InviteNotFound, teamName));
                }

                currentUser.ReceivedInvitations.FirstOrDefault(x => x.TeamId == team.Id && x.IsActive).IsActive = false;
                context.SaveChanges();
            }

            return $"Invite from {teamName} declined!";
        }
    }
}
