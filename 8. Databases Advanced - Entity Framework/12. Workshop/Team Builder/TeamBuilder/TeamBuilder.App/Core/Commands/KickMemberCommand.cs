using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;
using TeamBuilder.Models;

namespace TeamBuilder.App.Core.Commands
{
    public class KickMemberCommand
    {
        public string Execute(string[] args)
        {
            Check.CheckLength(2, args);

            string teamName = args[0];
            string username = args[1];

            if (!AuthenticationManager.IsAuthenticated())
            {
                throw new InvalidOperationException(Constants.ErrorMessages.LoginFirst);
            }

            var currentUser = AuthenticationManager.GetCurrentUser();

            using (TeamBuilderContext context = new TeamBuilderContext())
            {
                Team team = context.Teams.Include(x => x.Creator).FirstOrDefault(x => x.Name == teamName);

                if (team == null)
                {
                    throw new ArgumentException(string.Format(Constants.ErrorMessages.TeamNotFound, teamName));
                }

                User user = context.Users.Include(x => x.UserTeams).ThenInclude(x => x.Team).FirstOrDefault(x => x.Username == username);

                if (user == null)
                {
                    throw new ArgumentException(string.Format(Constants.ErrorMessages.UserNotFound, username));
                }

                if (!user.UserTeams.Any(x => x.TeamId == team.Id))
                {
                    throw new ArgumentException(string.Format(Constants.ErrorMessages.NotPartOfTeam, username, teamName));
                }

                if (currentUser.Id != team.CreatorId)
                {
                    throw new InvalidOperationException(Constants.ErrorMessages.NotAllowed);
                }

                if (user.Id == team.CreatorId)
                {
                    throw new InvalidOperationException(Constants.ErrorMessages.CommandNotAllowed);
                }

                UserTeam userTeam = user.UserTeams.FirstOrDefault(x => x.TeamId == team.Id);

                context.UserTeams.Remove(userTeam);
                context.SaveChanges();
            }

            return $"User {username} was kicked from {teamName}!";
        }
    }
}
