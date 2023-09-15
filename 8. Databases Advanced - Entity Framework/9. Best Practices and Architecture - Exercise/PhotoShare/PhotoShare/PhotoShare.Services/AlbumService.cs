using PhotoShare.Models;
using PhotoShare.Services.Contracts;
using System.Collections.Generic;
using System;
using PhotoShare.Data;
using System.Linq;
using AutoMapper.QueryableExtensions;
using PhotoShare.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace PhotoShare.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly PhotoShareContext context;

        public AlbumService(PhotoShareContext context)
        {
            this.context = context;
        }

        public TModel ById<TModel>(int id)
            => By<TModel>(x => x.Id == id).SingleOrDefault();

        public TModel ByName<TModel>(string name)
            => By<TModel>(x => x.Name == name).SingleOrDefault();

        public Album Create(int userId, string albumTitle, string BgColor, string[] tags)
        {
            var album = new Album
            {
                Name = albumTitle,
                BackgroundColor = Enum.Parse<Color>(BgColor, true)
            };

            context.Albums.Add(album);
            context.SaveChanges();

            var albumRole = new AlbumRole
            {
                Album = album,
                UserId = userId,
            };

            context.AlbumRoles.Add(albumRole);
            context.SaveChanges();

            foreach (var tag in tags)
            {
                var tagId = context.Tags.Where(x => x.Name == tag).FirstOrDefault().Id;

                var albumTag = new AlbumTag
                {
                    TagId = tagId,
                    Album = album
                };

                context.AlbumTags.Add(albumTag);
            }

            context.SaveChanges();

            return album;
        }

        public bool Exists(int id)
            => ById<Album>(id) != null;

        public bool Exists(string name)
            => ByName<Album>(name) != null;

        private IEnumerable<TModel> By<TModel>(Func<Album, bool> predicate)
            => context.Albums.Where(predicate).AsQueryable().ProjectTo<TModel>();
    }
}
