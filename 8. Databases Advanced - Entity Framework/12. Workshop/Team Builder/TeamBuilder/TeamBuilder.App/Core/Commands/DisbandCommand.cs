using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;
using TeamBuilder.Models;

namespace TeamBuilder.App.Core.Commands
{
    public class DisbandCommand
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
                Team team = context.Teams.Include(x => x.Creator).FirstOrDefault(x => x.Name == teamName);

                if (team == null)
                {
                    throw new ArgumentException(string.Format(Constants.ErrorMessages.TeamNotFound, teamName));
                }

                if (currentUser.Id != team.CreatorId)
                {
                    throw new InvalidOperationException(Constants.ErrorMessages.NotAllowed);
                }

                context.Teams.Remove(team);
                context.SaveChanges();
            }

            return $"{teamName} has disbanded!";
        }
    }
}
