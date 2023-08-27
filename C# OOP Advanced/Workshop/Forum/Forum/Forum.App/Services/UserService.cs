using Forum.App.Contracts.Models;
using Forum.App.Contracts.Services;
using Forum.Data;
using Forum.Models;
using System;
using System.Linq;

namespace Forum.App.Services
{
    public class UserService : IUserService
    {
        private ForumData forumData;
        private ISession session;

        public UserService(ForumData forumData, ISession session)
        {
            this.forumData = forumData;
            this.session = session;
        }

        public User GetUserById(int userId)
        {
            User user = forumData.Users.Where(x => x.Id == userId).FirstOrDefault();

            return user;
        }

        public string GetUserName(int userId)
        {
            User user = forumData.Users.Where(x => x.Id == userId).FirstOrDefault();

            return user.Username;
        }

        public bool TryLogInUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            User user = forumData.Users.FirstOrDefault(x => x.Username == username && x.Password == password);

            if (user == null)
            {
                return false;
            }

            session.Reset();
            session.LogIn(user);

            return true;
        }

        public bool TrySignUpUser(string username, string password)
        {
            bool validUsername = !string.IsNullOrWhiteSpace(username) && username.Length > 3;
            bool validPassword = !string.IsNullOrWhiteSpace(password) && password.Length > 3;

            if (!validUsername || !validPassword)
            {
                throw new ArgumentException("Username and Password must be longer than 3 symbols!");
            }

            bool userAlreadyExists = forumData.Users.Any(x => x.Username == username);

            if (userAlreadyExists)
            {
                throw new InvalidOperationException("Username taken!");
            }

            int userId = forumData.Users.LastOrDefault()?.Id + 1 ?? 1;

            User user = new User(userId, username, password);

            forumData.Users.Add(user);
            forumData.SaveChanges();

            TryLogInUser(username, password);

            return true;
        }
    }
}
