using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;
using TeamBuilder.Models;

namespace TeamBuilder.App.Core.Commands
{
    public class ShowTeamCommand
    {
        public string Execute(string[] args)
        {
            Check.CheckLength(1, args);

            string teamName = args[0];

            using (TeamBuilderContext context = new TeamBuilderContext())
            {
                Team team = context.Teams.Include(x => x.UserTeams).ThenInclude(x => x.User).FirstOrDefault(x => x.Name == teamName);

                if (team == null)
                {
                    throw new ArgumentException(string.Format(Constants.ErrorMessages.TeamNotFound, teamName));
                }

                return $"{team.Name} {team.Acronym}\r\nMembers:" + (team.UserTeams.Any() ? 
                    $"\r\n--{string.Join("\r\n--", team.UserTeams.Select(x => x.User.Username))}" : null);
            }
        }
    }
}
