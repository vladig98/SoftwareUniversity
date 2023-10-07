using IRunes.Data;
using IRunes.Models;
using IRunes.ViewModels;
using Microsoft.EntityFrameworkCore;
using SIS.Framework.ActionResults;
using SIS.Framework.Attributes.Methods;
using System;
using System.Linq;
using System.Web;

namespace IRunes.Controllers
{
    public class TracksController : BaseController
    {
        private readonly IRunesDbContext context;

        public TracksController(IRunesDbContext context)
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

            if (!Request.QueryData.ContainsKey("albumId"))
            {
                Model.Data["Error"] = "Invalid id!";
                return View();
            }

            string albumId = Request.QueryData["albumId"].ToString();

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

            if (!Request.QueryData.ContainsKey("trackId"))
            {
                Model.Data["Error"] = "Invalid id!";
                return View();
            }

            string trackId = Request.QueryData["trackId"].ToString();

            if (string.IsNullOrEmpty(trackId) || string.IsNullOrWhiteSpace(trackId))
            {
                Model.Data["Error"] = "Invalid id!";
                return View();
            }

            var track = context.Tracks.FirstOrDefault(x => x.Id == trackId);

            if (track == null)
            {
                Model.Data["Error"] = "Invalid id!";
                return View();
            }

            if (!album.Tracks.Any(x => x == track))
            {
                Model.Data["Error"] = "Invalid id!";
                return View();
            }

            Model.Data["TrackName"] = track.Name;
            Model.Data["TrackPrice"] = track.Price.ToString("F2");
            Model.Data["TrackVideoURL"] = HttpUtility.UrlDecode(track.Link);
            Model.Data["AlbumId"] = album.Id;

            return View();
        }

        [HttpPost]
        public IActionResult Create(TrackViewModel model)
        {
            if (Identity == null)
            {
                Model.Data["Error"] = "You are not logged in!";
                return View();
            }

            if (!Request.QueryData.ContainsKey("albumId"))
            {
                Model.Data["Error"] = "Invalid id!";
                return View();
            }

            string albumId = Request.QueryData["albumId"].ToString();

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

            string name = model.name;
            string link = model.link;
            string price = model.price;

            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)
                || string.IsNullOrEmpty(link) || string.IsNullOrWhiteSpace(link)
                || string.IsNullOrEmpty(price) || string.IsNullOrWhiteSpace(price))
            {
                Model.Data["Error"] = "Invalid data!";
                return View();
            }

            var isPriceValid = decimal.TryParse(price, out decimal parsedPrice);

            if (!isPriceValid)
            {
                Model.Data["Error"] = "Invalid data!";
                return View();
            }

            Track track = new Track
            {
                AlbumId = albumId,
                Link = link,
                Name = name,
                Price = parsedPrice,
                Id = Guid.NewGuid().ToString()
            };

            context.Tracks.Add(track);
            context.SaveChanges();

            return RedirectToAction("/Albums/Details/?id=" + albumId);
        }

        public IActionResult Create()
        {
            if (Identity == null)
            {
                Model.Data["Error"] = "You are not logged in!";
                return View();
            }

            if (!Request.QueryData.ContainsKey("albumId"))
            {
                Model.Data["Error"] = "Invalid id!";
                return View();
            }

            string albumId = Request.QueryData["albumId"].ToString();

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

            Model.Data["AlbumId"] = album.Id;
            Model.Data["IdBack"] = album.Id;

            return View();
        }
    }
}
