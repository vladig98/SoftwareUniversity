using PhotoShare.Client.Core.Contracts;
using PhotoShare.Client.Core.Dtos;
using PhotoShare.Client.Utilities;
using PhotoShare.Models.Enums;
using PhotoShare.Services.Contracts;
using System;
using System.Linq;

namespace PhotoShare.Client.Core.Commands
{
    public class CreateAlbumCommand : ICommand
    {
        private readonly IAlbumService albumService;
        private readonly IUserService userService;
        private readonly ITagService tagService;

        public CreateAlbumCommand(IAlbumService albumService, IUserService userService, ITagService tagService)
        {
            this.albumService = albumService;
            this.userService = userService;
            this.tagService = tagService;
        }

        // CreateAlbum <username> <albumTitle> <BgColor> <tag1> <tag2>...<tagN>
        public string Execute(string[] data)
        {
            if (data.Length < 3)
            {
                return "Invalid data.";
            }

            string username = data[0];
            string albumTitle = data[1];
            string bgColor = data[2];
            string[] tagNames = data.Skip(3).ToArray();

            bool userExists = userService.Exists(username);

            if (!userExists)
            {
                throw new ArgumentException($"User {username} not found!");
            }

            var user = userService.ByUsername<UserDto>(username);

            if (!user.LastTimeLoggedIn.HasValue)
            {
                return "Invalid credentials!";
            }

            bool albumExists = albumService.Exists(albumTitle);

            if (albumExists)
            {
                throw new ArgumentException($"Album {albumTitle} exists!");
            }

            bool colorExists = Enum.TryParse(bgColor, true, out Color color);

            if (!colorExists)
            {
                throw new ArgumentException($"Color {bgColor} not found!");
            }

            tagNames = tagNames.Select(x => x.ValidateOrTransform()).ToArray();

            foreach (var tagName in tagNames)
            {
                bool tagExists = tagService.Exists(tagName);

                if (!tagExists)
                {
                    throw new ArgumentException($"Invalid tags!");
                }
            }

            albumService.Create(user.Id, albumTitle, bgColor, tagNames);

            return $"Album {albumTitle} successfully created!";
        }
    }
}
