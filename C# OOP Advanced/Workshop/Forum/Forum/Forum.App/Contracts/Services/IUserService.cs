using Forum.Models;

namespace Forum.App.Contracts.Services
{
    public interface IUserService
    {
        bool TrySignUpUser(string username, string password);

        bool TryLogInUser(string username, string password);

        string GetUserName(int userId);

        User GetUserById(int userId);
    }
}
