using PhotoShare.Client.Core.Contracts;
using PhotoShare.Client.Core.Dtos;
using PhotoShare.Client.Utilities;
using PhotoShare.Models.Enums;
using PhotoShare.Services;
using PhotoShare.Services.Contracts;
using System;
using System.Linq;

namespace PhotoShare.Client.Core.Commands
{
    public class AddTagToCommand : ICommand
    {
        private readonly IAlbumService albumService;
        private readonly ITagService tagService;
        private readonly IAlbumTagService albumTagService;
        private readonly IAlbumRoleService albumRoleService;
        private readonly IUserService userService;

        public AddTagToCommand(IAlbumService albumService, ITagService tagService, IAlbumTagService albumTagService,
            IAlbumRoleService albumRoleService, IUserService userService)
        {
            this.albumService = albumService;
            this.tagService = tagService;
            this.albumTagService = albumTagService;
            this.userService = userService;
            this.albumRoleService = albumRoleService;
        }

        // AddTagTo <albumName> <tag>
        public string Execute(string[] args)
        {
            if (args.Length != 2)
            {
                return "Invalid data.";
            }

            string albumName = args[0];
            string tagName = args[1];

            bool albumExists = albumService.Exists(albumName);
            bool tagExists = tagService.Exists(tagName.ValidateOrTransform());

            if (!albumExists || !tagExists)
            {
                throw new ArgumentException($"Either tag or album do not exist!");
            }

            var albumRoles = albumRoleService.ByAlbumName<AlbumRoleDto>(albumName);

            var userName = albumRoles.Where(x => x.Role == Role.Owner).FirstOrDefault().Username;
            var user = userService.ByUsername<UserDto>(userName);

            if (!user.LastTimeLoggedIn.HasValue)
            {
                return "Invalid credentials";
            }

            int albumId = albumService.ByName<AlbumDto>(albumName).Id;
            int tagId = tagService.ByName<TagDto>(tagName.ValidateOrTransform()).Id;

            albumTagService.AddTagTo(albumId, tagId);

            return $"Tag {tagName} added to {albumName}!";
        }
    }
}
