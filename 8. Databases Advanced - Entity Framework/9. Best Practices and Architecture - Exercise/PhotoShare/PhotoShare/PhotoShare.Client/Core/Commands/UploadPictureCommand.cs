using PhotoShare.Client.Core.Contracts;
using PhotoShare.Client.Core.Dtos;
using PhotoShare.Models.Enums;
using PhotoShare.Services.Contracts;
using System;
using System.Linq;

namespace PhotoShare.Client.Core.Commands
{
    public class UploadPictureCommand : ICommand
    {
        private readonly IPictureService pictureService;
        private readonly IAlbumService albumService;
        private readonly IAlbumRoleService albumRoleService;
        private readonly IUserService userService;

        public UploadPictureCommand(IPictureService pictureService, IAlbumService albumService, 
            IAlbumRoleService albumRoleService, IUserService userService)
        {
            this.pictureService = pictureService;
            this.albumService = albumService;
            this.albumRoleService = albumRoleService;
            this.userService = userService;
        }

        // UploadPicture <albumName> <pictureTitle> <pictureFilePath>
        public string Execute(string[] data)
        {
            if (data.Length != 3)
            {
                return "Invalid data.";
            }

            string albumName = data[0];
            string pictureTitle = data[1];
            string path = data[2];

            var albumExists = this.albumService.Exists(albumName);

            if (!albumExists)
            {
                throw new ArgumentException($"Album {albumName} not found!");
            }

            var albumRoles = albumRoleService.ByAlbumName<AlbumRoleDto>(albumName);

            var userName = albumRoles.Where(x => x.Role == Role.Owner).FirstOrDefault().Username;
            var user = userService.ByUsername<UserDto>(userName);

            if (!user.LastTimeLoggedIn.HasValue)
            {
                return "Invalid credentials";
            }

            var albumId = this.albumService.ByName<AlbumDto>(albumName).Id;

            var picture = this.pictureService.Create(albumId, pictureTitle, path);

            return $"Picture {pictureTitle} added to {albumName}!";
        }
    }
}
