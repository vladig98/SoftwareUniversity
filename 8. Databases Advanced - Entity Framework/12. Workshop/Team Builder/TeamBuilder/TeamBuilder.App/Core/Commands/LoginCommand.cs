using System;
using System.Linq;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;
using TeamBuilder.Models;

namespace TeamBuilder.App.Core.Commands
{
    public class LoginCommand
    {
        public string Execute(string[] args)
        {
            Check.CheckLength(2, args);

            string username = args[0];
            string password = args[1];

            if (AuthenticationManager.IsAuthenticated())
            {
                throw new InvalidOperationException(Constants.ErrorMessages.LogoutFirst);
            }

            User user = GetUserByCredentials(username, password);

            if (user == null)
            {
                throw new ArgumentException(Constants.ErrorMessages.UserOrPasswordIsInvalid);
            }

            AuthenticationManager.Login(user);

            return $"User {username} successfully logged in!";
        }

        private User GetUserByCredentials(string username, string password)
        {
            using (TeamBuilderContext context = new TeamBuilderContext())
            {
                return context.Users.FirstOrDefault(x => x.Username == username && x.Password == password && !x.IsDeleted);
            }
        }
    }
}
