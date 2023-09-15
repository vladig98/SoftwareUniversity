using PhotoShare.Client.Core.Contracts;
using PhotoShare.Client.Core.Dtos;
using PhotoShare.Models.Enums;
using PhotoShare.Services.Contracts;
using System;
using System.Linq;

namespace PhotoShare.Client.Core.Commands
{
    public class ShareAlbumCommand : ICommand
    {
        private readonly IAlbumService albumService;
        private readonly IUserService userService;
        private readonly IAlbumRoleService albumRoleService;

        public ShareAlbumCommand(IAlbumService albumService, IUserService userService, IAlbumRoleService albumRoleService)
        {
            this.albumService = albumService;
            this.userService = userService;
            this.albumRoleService = albumRoleService;
        }
        // ShareAlbum <albumId> <username> <permission>
        // For example:
        // ShareAlbum 4 dragon321 Owner
        // ShareAlbum 4 dragon11 Viewer
        public string Execute(string[] data)
        {
            if (data.Length != 3)
            {
                return "Invalid data.";
            }

            string username = data[1];
            string permission = data[2];

            var isIdValid = int.TryParse(data[0], out int albumId);

            if (!isIdValid)
            {
                throw new ArgumentException("Invalid data.");
            }

            bool albumExists = albumService.Exists(albumId);

            if (!albumExists)
            {
                throw new ArgumentException($"Album {albumId} not found!");
            }

            bool userExists = userService.Exists(username);

            if (!userExists)
            {
                throw new ArgumentException($"User {username} not found!");
            }

            bool isPermissionValid = Enum.TryParse(permission, true, out Role role);

            if (!isPermissionValid)
            {
                throw new ArgumentException($"Permission must be either \"Owner\" or \"Viewer\"!");
            }

            if (!CheckIfTheOwnerIsLoggedIn(albumId))
            {
                return "Invalid Credentials";
            }

            var user = userService.ByUsername<UserDto>(username);

            var albumName = albumService.ById<AlbumDto>(albumId).Name;

            albumRoleService.PublishAlbumRole(albumId, user.Id, permission);

            return $"Username {username} added to album {albumName} ({permission})";
        }

        private bool CheckIfTheOwnerIsLoggedIn(int albumId)
        {
            var users = userService.GetAllUsers();

            var LoggedInUsers = users.Where(x => x.LastTimeLoggedIn.HasValue).ToArray();

            if (LoggedInUsers.Length == 0)
            {
                return false;
            }
            else
            {
                var albumroles = albumRoleService.ByAlbumId<AlbumRoleDto>(albumId);

                var userRoles = albumroles.Where(x => LoggedInUsers.Where(y => y.Username == x.Username).Any()).ToArray();

                if (userRoles.Length == 0)
                {
                    return false;
                }

                if (!userRoles.Where(x => x.Role == Role.Owner).Any())
                {
                    return false;
                }
            }

            return true;
        }
    }
}
