using PhotoShare.Client.Core.Contracts;
using PhotoShare.Client.Utilities;
using PhotoShare.Services.Contracts;
using System;
using System.Linq;

namespace PhotoShare.Client.Core.Commands
{
    public class AddTagCommand : ICommand
    {
        private readonly ITagService tagService;
        private readonly IUserService userService;

        public AddTagCommand(ITagService tagService, IUserService userService)
        {
            this.tagService = tagService;
            this.userService = userService;

        }

        public string Execute(string[] args)
        {
            var users = userService.GetAllUsers();

            if (!users.Where(x => x.LastTimeLoggedIn.HasValue).Any())
            {
                return "Invalid credentials!";
            }

            if (args.Length != 1)
            {
                return "Invalid data.";
            }

            string tagName = args[0];

            var tagExists = tagService.Exists(tagName);

            if (tagExists)
            {
                throw new ArgumentException($"Tag {tagName} exists!");
            }

            tagName = tagName.ValidateOrTransform();

            var tag = tagService.AddTag(tagName);

            return $"Tag {tagName} was added successfully!";
        }
    }
}
