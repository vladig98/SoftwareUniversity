using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using PhotoShare.Data;
using PhotoShare.Models;
using PhotoShare.Models.Enums;
using PhotoShare.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PhotoShare.Services
{
    public class AlbumRoleService : IAlbumRoleService
    {
        private readonly PhotoShareContext context;

        public AlbumRoleService(PhotoShareContext context)
        {
            this.context = context;
        }

        public AlbumRole PublishAlbumRole(int albumId, int userId, string role)
        {
            var roleAsEnum = Enum.Parse<Role>(role);

            var albumRole = new AlbumRole()
            {
                AlbumId = albumId,
                UserId = userId,
                Role = roleAsEnum
            };

            this.context.AlbumRoles.Add(albumRole);

            this.context.SaveChanges();

            return albumRole;
        }

        public TModel[] ByAlbumId<TModel>(int id)
            => By<TModel>(x => x.AlbumId == id).ToArray();

        public TModel[] ByUserId<TModel>(int id)
            => By<TModel>(x => x.UserId == id).ToArray();

        public TModel[] ByAlbumName<TModel>(string name)
            => By<TModel>(x => x.Album.Name == name).ToArray();

        public TModel[] ByUserName<TModel>(string name)
            => By<TModel>(x => x.User.Username == name).ToArray();

        private IEnumerable<TModel> By<TModel>(Func<AlbumRole, bool> predicate)
            => context.AlbumRoles.Where(predicate).AsQueryable().ProjectTo<TModel>();
    }
}
