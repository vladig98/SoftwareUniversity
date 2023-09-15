using Microsoft.EntityFrameworkCore.Internal;
using PhotoShare.Client.Core.Contracts;
using PhotoShare.Client.Core.Dtos;
using PhotoShare.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhotoShare.Client.Core.Commands
{
    public class PrintFriendsListCommand : ICommand
    {
        private readonly IUserService userService;

        public PrintFriendsListCommand(IUserService userService)
        {
            this.userService = userService;
        }

        public string Execute(string[] args)
        {
            if (args.Length != 1)
            {
                return "Invalid data.";
            }

            string username = args[0];

            bool userExists = userService.Exists(username);

            if (!userExists)
            {
                throw new ArgumentException($"User {username} not found!");
            }

            var user = userService.ByUsername<UserFriendsDto>(username);

            if (!user.Friends.Any())
            {
                return "No friends for this user. :(";
            }

            var friends = user.Friends.ToList();

            var friendUsers = new List<UserFriendsDto>();

            foreach (var friend in friends)
            {
                friendUsers.Add(userService.ByUsername<UserFriendsDto>(friend.Username));
            }

            friendUsers = friendUsers.Where(x => x.Friends.Where(y => y.Username == user.Username).Any()).ToList();

            if (!friendUsers.Any())
            {
                return "No friends for this user. :(";
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Friends:");

            foreach (var friend in friends)
            {
                sb.AppendLine($"-{friend.Username}");
            }

            return sb.ToString();
        }
    }
}
