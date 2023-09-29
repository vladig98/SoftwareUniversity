using IRunes.Data;
using IRunes.Models;
using Microsoft.EntityFrameworkCore;
using SIS.HTTP.Enums;
using SIS.HTTP.Requests;
using SIS.HTTP.Responses;
using SIS.WebServer.Results;
using System;
using System.IO;
using System.Linq;
using System.Web;

namespace IRunes.Controllers
{
    public class TracksController
    {
        private const string PathToViews = "../../../Views/";
        private readonly IRunesDbContext context;

        public TracksController()
        {
            context = new IRunesDbContext();
        }

        public IHttpResponse Details(IHttpRequest request)
        {
            if (!request.Cookies.ContainsCookie(".auth"))
            {
                return new HtmlResult("<h1 style=\"color: red;\">You are not logged in.</h1>", HttpResponseStatusCode.BadRequest);
            }

            if (!request.QueryData.ContainsKey("albumId"))
            {
                return new HtmlResult("<h1 style=\"color: red;\">Invalid Id.</h1>", HttpResponseStatusCode.BadRequest);
            }

            string albumId = request.QueryData["albumId"].ToString();

            if (string.IsNullOrEmpty(albumId) || string.IsNullOrWhiteSpace(albumId))
            {
                return new HtmlResult("<h1 style=\"color: red;\">Invalid Id.</h1>", HttpResponseStatusCode.BadRequest);
            }

            var album = context.Albums.Include(x => x.Tracks).FirstOrDefault(x => x.Id == albumId);

            if (album == null)
            {
                return new HtmlResult("<h1 style=\"color: red;\">Invalid Id.</h1>", HttpResponseStatusCode.BadRequest);
            }

            if (!request.QueryData.ContainsKey("trackId"))
            {
                return new HtmlResult("<h1 style=\"color: red;\">Invalid Id.</h1>", HttpResponseStatusCode.BadRequest);
            }

            string trackId = request.QueryData["trackId"].ToString();

            if (string.IsNullOrEmpty(trackId) || string.IsNullOrWhiteSpace(trackId))
            {
                return new HtmlResult("<h1 style=\"color: red;\">Invalid Id.</h1>", HttpResponseStatusCode.BadRequest);
            }

            var track = context.Tracks.FirstOrDefault(x => x.Id == trackId);

            if (track == null)
            {
                return new HtmlResult("<h1 style=\"color: red;\">Invalid Id.</h1>", HttpResponseStatusCode.BadRequest);
            }

            if (!album.Tracks.Any(x => x == track))
            {
                return new HtmlResult("<h1 style=\"color: red;\">Invalid Id.</h1>", HttpResponseStatusCode.BadRequest);
            }

            string content = File.ReadAllText(PathToViews + "TrackDetails.html");

            content = content.Replace("{{videoLink}}", HttpUtility.UrlDecode(track.Link));
            content = content.Replace("{{name}}", track.Name);
            content = content.Replace("{{price}}", track.Price.ToString("F2"));
            content = content.Replace("{{albumIdBack}}", albumId);

            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }

        public IHttpResponse CreatePost(IHttpRequest request)
        {
            if (!request.Cookies.ContainsCookie(".auth"))
            {
                return new HtmlResult("<h1 style=\"color: red;\">You are not logged in.</h1>", HttpResponseStatusCode.BadRequest);
            }

            if (!request.QueryData.ContainsKey("albumId"))
            {
                return new HtmlResult("<h1 style=\"color: red;\">Invalid Id.</h1>", HttpResponseStatusCode.BadRequest);
            }

            string albumId = request.QueryData["albumId"].ToString();

            if (string.IsNullOrEmpty(albumId) || string.IsNullOrWhiteSpace(albumId))
            {
                return new HtmlResult("<h1 style=\"color: red;\">Invalid Id.</h1>", HttpResponseStatusCode.BadRequest);
            }

            var album = context.Albums.Include(x => x.Tracks).FirstOrDefault(x => x.Id == albumId);

            if (album == null)
            {
                return new HtmlResult("<h1 style=\"color: red;\">Invalid Id.</h1>", HttpResponseStatusCode.BadRequest);
            }

            string name = request.FormData["name"].ToString();
            string link = request.FormData["link"].ToString();
            string price = request.FormData["price"].ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)
                || string.IsNullOrEmpty(link) || string.IsNullOrWhiteSpace(link)
                || string.IsNullOrEmpty(price) || string.IsNullOrWhiteSpace(price))
            {
                return new HtmlResult("<h1 style=\"color: red;\">Invalid data</h1>", HttpResponseStatusCode.BadRequest);
            }

            var isPriceValid = decimal.TryParse(price, out decimal parsedPrice);

            if (!isPriceValid)
            {
                return new HtmlResult("<h1 style=\"color: red;\">Invalid data</h1>", HttpResponseStatusCode.BadRequest);
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

            return new RedirectResult("/Albums/Details?id=" + albumId);
        }

        public IHttpResponse Create(IHttpRequest request)
        {
            if (!request.Cookies.ContainsCookie(".auth"))
            {
                return new HtmlResult("<h1 style=\"color: red;\">You are not logged in.</h1>", HttpResponseStatusCode.BadRequest);
            }

            if (!request.QueryData.ContainsKey("albumId"))
            {
                return new HtmlResult("<h1 style=\"color: red;\">Invalid Id.</h1>", HttpResponseStatusCode.BadRequest);
            }

            string albumId = request.QueryData["albumId"].ToString();

            if (string.IsNullOrEmpty(albumId) || string.IsNullOrWhiteSpace(albumId))
            {
                return new HtmlResult("<h1 style=\"color: red;\">Invalid Id.</h1>", HttpResponseStatusCode.BadRequest);
            }

            var album = context.Albums.Include(x => x.Tracks).FirstOrDefault(x => x.Id == albumId);

            if (album == null)
            {
                return new HtmlResult("<h1 style=\"color: red;\">Invalid Id.</h1>", HttpResponseStatusCode.BadRequest);
            }

            string content = File.ReadAllText(PathToViews + "CreateTrack.html");

            content = content.Replace("{{albumId}}", albumId);
            content = content.Replace("{{albumIdBack}}", albumId);

            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }
    }
}
