using IRunes.Data;
using IRunes.Models;
using IRunes.ViewModels;
using Microsoft.EntityFrameworkCore;
using SIS.Framework.ActionResults;
using SIS.Framework.Attributes.Methods;
using SIS.Framework.Controllers;
using SIS.HTTP.Enums;
using SIS.HTTP.Requests;
using SIS.HTTP.Responses;
using SIS.WebServer.Results;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IRunes.Controllers
{
    public class AlbumsController : BaseController
    {
        private readonly IRunesDbContext context;

        public AlbumsController(IRunesDbContext context)
        {
            this.context = context;
        }

        public IActionResult Details()
        {
            if (Identity == null)
            {
                Model.Data["Error"] = "You are not logged in!";
                return View();
            }

            if (!Request.QueryData.ContainsKey("id"))
            {
                Model.Data["Error"] = "Invalid id!";
                return View();
            }

            string albumId = Request.QueryData["id"].ToString();

            if (string.IsNullOrEmpty(albumId) || string.IsNullOrWhiteSpace(albumId))
            {
                Model.Data["Error"] = "Invalid id!";
                return View();
            }

            var album = context.Albums.Include(x => x.Tracks).FirstOrDefault(x => x.Id == albumId);

            if (album == null)
            {
                Model.Data["Error"] = "Invalid id!";
                return View();
            }

            var tracks = album.Tracks.ToList();

            Model.Data["AlbumPhotoURL"] = HttpUtility.UrlDecode(album.Cover);
            Model.Data["AlbumName"] = album.Name;
            Model.Data["AlbumPrice"] = album.Price.ToString("F2");
            Model.Data["AlbumId"] = album.Id;

            List<TracksViewModel> tracksVies = new List<TracksViewModel>();

            int counter = 1;

            foreach (var track in tracks)
            {
                tracksVies.Add(new TracksViewModel
                {
                    TrackId = track.Id,
                    TrackName = track.Name,
                    AlbumId = album.Id,
                    Index = counter++
                });
            }

            Model.Data["Tracks"] = tracksVies;

            return View();
        }

        [HttpPost]
        public IActionResult Create(AlbumViewModel model)
        {
            if (Identity == null)
            {
                Model.Data["Error"] = "You are not logged in!";
                return View();
            }

            string name = model.name;
            string cover = model.cover;

            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)
                || string.IsNullOrEmpty(cover) || string.IsNullOrWhiteSpace(cover))
            {
                Model.Data["Error"] = "Invalid data!";
                return View();
            }

            Album album = new Album
            {
                Cover = cover,
                Name = name,
                Id = Guid.NewGuid().ToString()
            };

            context.Albums.Add(album);
            context.SaveChanges();

            return RedirectToAction("/Albums/All");
        }

        public IActionResult Create()
        {
            if (Identity == null)
            {
                Model.Data["Error"] = "You are not logged in!";
                return View();
            }

            return View();
        }

        public IActionResult All()
        {
            if (Identity == null)
            {
                Model.Data["Error"] = "You are not logged in!";
                return View();
            }

            var albums = context.Albums.ToList();

            List<AlbumsViewModel> albumViews = new List<AlbumsViewModel>();

            foreach (var album in albums)
            {
                albumViews.Add(new AlbumsViewModel
                {
                    AlbumId = album.Id,
                    AlbumName = album.Name
                });
            }

            Model.Data["Albums"] = albumViews;

            return View();
        }
    }
}
