using System;
using System.Linq;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;
using TeamBuilder.Models;

namespace TeamBuilder.App.Core.Commands
{
    public class CreateTeamCommand
    {
        public string Execute(string[] args)
        {
            if (args.Length < 2 || args.Length > 3)
            {
                throw new FormatException(Constants.ErrorMessages.InvalidArgumentsCount);
            }

            string name = args[0];
            string acronym = args[1];
            string description = args.Length > 2 ? args[2] : null;

            using (TeamBuilderContext context = new TeamBuilderContext())
            {
                if (context.Teams.Any(x => x.Name == name))
                {
                    throw new ArgumentException(string.Format(Constants.ErrorMessages.TeamExists, name));
                }

                if (acronym.Length != 3)
                {
                    throw new ArgumentException(Constants.ErrorMessages.InvalidAcronym);
                }

                if (!AuthenticationManager.IsAuthenticated())
                {
                    throw new InvalidOperationException(Constants.ErrorMessages.LoginFirst);
                }

                User currentUser = AuthenticationManager.GetCurrentUser();

                currentUser = context.Users.FirstOrDefault(x => x == currentUser);

                Team team = new Team
                {
                    Acronym = acronym,
                    CreatorId = currentUser.Id,
                    Description = description,
                    Name = name
                };

                context.Teams.Add(team);
                context.SaveChanges();
            }

            return $"Team {name} successfully created!";
        }
    }
}
