using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using PhotoShare.Data;
using PhotoShare.Models;
using PhotoShare.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PhotoShare.Services
{
    public class UserService : IUserService
    {
        private readonly PhotoShareContext context;

        public UserService(PhotoShareContext context)
        {
            this.context = context;
        }

        public List<User> GetAllUsers() => context.Users.ToList();

        public void Logout(string username)
        {
            //Automapper limitation is not allowing me to use the By method I have
            //The Automapper creates a new instance of the object and the context is not updated
            var user = context.Users.FirstOrDefault(x => x.Username == username);

            user.LastTimeLoggedIn = null;

            context.SaveChanges();
        }

        public void Login(string username)
        {
            //Automapper limitation is not allowing me to use the By method I have
            //The Automapper creates a new instance of the object and the context is not updated
            var user = context.Users.FirstOrDefault(x => x.Username == username);

            user.LastTimeLoggedIn = DateTime.Now;

            context.SaveChanges();
        }

        public Friendship AcceptFriend(int userId, int friendId)
        {
            var friendship = new Friendship
            {
                UserId = userId,
                FriendId = friendId
            };

            context.Friendships.Add(friendship);

            context.SaveChanges();

            return friendship;
        }

        public Friendship AddFriend(int userId, int friendId)
        {
            var friendship = new Friendship
            {
                UserId = userId,
                FriendId = friendId
            };

            context.Friendships.Add(friendship);

            context.SaveChanges();

            return friendship;
        }

        public TModel ById<TModel>(int id)
            => By<TModel>(x => x.Id == id).SingleOrDefault();

        public TModel ByUsername<TModel>(string username)
            => By<TModel>(x => x.Username == username).SingleOrDefault();

        public void ChangePassword(int userId, string password)
        {
            //Automapper limitation is not allowing me to use the By method I have
            //The Automapper creates a new instance of the object and the context is not updated
            var user = context.Users.FirstOrDefault(x => x.Id == userId);

            user.Password = password;

            context.SaveChanges();
        }

        public void Delete(string username)
        {
            //Automapper limitation is not allowing me to use the By method I have
            //The Automapper creates a new instance of the object and the context is not updated
            var user = context.Users.FirstOrDefault(x => x.Username == username);

            user.IsDeleted = true;

            context.SaveChanges();
        }

        public bool Exists(int id)
            => ById<User>(id) != null;

        public bool Exists(string name)
            => ByUsername<User>(name) != null;

        public User Register(string username, string password, string email)
        {
            var user = new User
            {
                Username = username,
                Password = password,
                Email = email,
                IsDeleted = false
            };

            context.Users.Add(user);

            context.SaveChanges();

            return user;
        }

        public void SetBornTown(int userId, int townId)
        {
            //Automapper limitation is not allowing me to use the By method I have
            //The Automapper creates a new instance of the object and the context is not updated
            var user = context.Users.FirstOrDefault(x => x.Id == userId);

            user.BornTownId = townId;

            context.SaveChanges();
        }

        public void SetCurrentTown(int userId, int townId)
        {
            //Automapper limitation is not allowing me to use the By method I have
            //The Automapper creates a new instance of the object and the context is not updated
            var user = context.Users.FirstOrDefault(x => x.Id == userId);

            user.CurrentTownId = townId;

            context.SaveChanges();
        }

        private IEnumerable<TModel> By<TModel>(Func<User, bool> predicate)
            => context.Users.Include(x => x.FriendsAdded).Include(x => x.AlbumRoles).Where(predicate).AsQueryable().ProjectTo<TModel>();
    }
}
