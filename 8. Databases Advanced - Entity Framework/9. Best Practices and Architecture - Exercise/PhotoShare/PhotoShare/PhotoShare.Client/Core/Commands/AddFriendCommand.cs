using Microsoft.EntityFrameworkCore.Internal;
using PhotoShare.Client.Core.Contracts;
using PhotoShare.Client.Core.Dtos;
using PhotoShare.Services.Contracts;
using System;
using System.Linq;

namespace PhotoShare.Client.Core.Commands
{
    public class AddFriendCommand : ICommand
    {
        private readonly IUserService userService;

        public AddFriendCommand(IUserService userService)
        {
            this.userService = userService;
        }

        // AddFriend <username1> <username2>
        public string Execute(string[] data)
        {
            if (data.Length != 2)
            {
                return "Invalid data.";
            }

            string username = data[0];
            string friend = data[1];

            bool isUserValid = userService.Exists(username);
            bool isFriendValid = userService.Exists(friend);

            if (!isUserValid)
            {
                throw new ArgumentException($"{username} not found!");
            }

            if (!isFriendValid)
            {
                throw new ArgumentException($"{friend} not found!");
            }

            var loggeduser =userService.ByUsername<UserDto>(username);

            if (!loggeduser.LastTimeLoggedIn.HasValue)
            {
                return "Invalid credentials!";
            }

            var user = userService.ByUsername<UserFriendsDto>(username);
            var friendUser = userService.ByUsername<UserFriendsDto>(friend);

            bool userHasTheFriend = user.Friends.Where(x => x.Username == friend).Any();
            bool friendHasTheUserAsFriend = friendUser.Friends.Where(x => x.Username == username).Any();

            if (userHasTheFriend && friendHasTheUserAsFriend)
            {
                throw new InvalidOperationException($"{friend} is already a friend to {username}");
            }
            else if (userHasTheFriend && !friendHasTheUserAsFriend)
            {
                throw new InvalidOperationException($"{friend} has not added {username} as a friend");
            }
            else if (!userHasTheFriend && friendHasTheUserAsFriend)
            {
                throw new InvalidOperationException($"{username} has not added {friend} as a friend");
            }

            userService.AddFriend(user.Id, friendUser.Id);

            return $"Friend {friend} added to {username}";
        }
    }
}
