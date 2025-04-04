﻿using System.Collections.Generic;
using System;
using PhotoShare.Services.Contracts;
using PhotoShare.Data;
using PhotoShare.Models;
using System.Linq;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace PhotoShare.Services
{
    public class PictureService : IPictureService
    {
        private readonly PhotoShareContext context;

        public PictureService(PhotoShareContext context)
        {
            this.context = context;
        }

        public TModel ById<TModel>(int id)
                => By<TModel>(a => a.Id == id).SingleOrDefault();

        public TModel ByTitle<TModel>(string name)
            => By<TModel>(a => a.Title == name).SingleOrDefault();

        public bool Exists(int id)
            => ById<Picture>(id) != null;

        public bool Exists(string name)
           => ByTitle<Picture>(name) != null;

        private IEnumerable<TModel> By<TModel>(Func<Picture, bool> predicate) =>
            this.context.Pictures
                .Where(predicate)
                .AsQueryable()
                .ProjectTo<TModel>();

        public Picture Create(int albumId, string pictureTitle, string pictureFilePath)
        {
            var picture = new Picture()
            {
                Title = pictureTitle,
                Path = pictureFilePath,
                AlbumId = albumId
            };

            this.context.Pictures.Add(picture);

            this.context.SaveChanges();

            return picture;
        }
    }
}
