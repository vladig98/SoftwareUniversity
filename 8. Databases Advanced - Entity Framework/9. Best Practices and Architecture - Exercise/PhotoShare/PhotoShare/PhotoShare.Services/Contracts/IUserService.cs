using PhotoShare.Models;
using System.Collections.Generic;

namespace PhotoShare.Services.Contracts
{
    public interface IUserService
    {
        TModel ById<TModel>(int id);

        TModel ByUsername<TModel>(string username);

        bool Exists(int id);

        bool Exists(string name);

        User Register(string username, string password, string email);

        void Delete(string username);

        Friendship AddFriend(int userId, int friendId);

        Friendship AcceptFriend(int userId, int friendId);

        void ChangePassword(int userId, string password);

        void SetBornTown(int userId, int townIde);

        void SetCurrentTown(int userId, int townId);

        void Login(string username);

        void Logout(string username);

        List<User> GetAllUsers();
    }
}
