using System;
using System.Linq;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;
using TeamBuilder.Models;

namespace TeamBuilder.App.Core.Commands
{
    public class InviteToTeamCommand
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

            User currentUser = AuthenticationManager.GetCurrentUser();

            using (TeamBuilderContext context = new TeamBuilderContext())
            {
                Team team = context.Teams.FirstOrDefault(x => x.Name == teamName);

                if (team == null)
                {
                    throw new ArgumentException(Constants.ErrorMessages.TeamOrUserNotExist);
                }

                User user = context.Users.FirstOrDefault(x => x.Username == username);

                if (user == null)
                {
                    throw new ArgumentException(Constants.ErrorMessages.TeamOrUserNotExist);
                }

                if (team.CreatorId != currentUser.Id)
                {
                    if (!team.UserTeams.Any(x => x.UserId == currentUser.Id))
                    {
                        throw new InvalidOperationException(Constants.ErrorMessages.NotAllowed);
                    }
                }

                if (team.UserTeams.Any(x => x.UserId == user.Id))
                {
                    throw new InvalidOperationException(Constants.ErrorMessages.NotAllowed);
                }

                if (user.ReceivedInvitations.Any(x => x.TeamId == team.Id && x.IsActive))
                {
                    throw new InvalidCastException(Constants.ErrorMessages.InviteIsAlreadySent);
                }

                if (team.CreatorId == user.Id)
                {
                    UserTeam userTeam = new UserTeam
                    {
                        TeamId = team.Id,
                        UserId = user.Id
                    };

                    context.UserTeams.Add(userTeam);
                    context.SaveChanges();

                    return $"User {user.Username} joined team {teamName}!";
                }

                Invitation invitation = new Invitation
                {
                    InvitedUserId = user.Id,
                    IsActive = true,
                    TeamId = team.Id
                };

                context.Invitations.Add(invitation);
                context.SaveChanges();
            }

            return $"Team {teamName} invited {username}!";
        }
    }
}
