using IRunes.Data;
using IRunes.Models;
using Microsoft.EntityFrameworkCore;
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
    public class AlbumsController
    {
        private const string PathToViews = "../../../Views/";
        private readonly IRunesDbContext context;

        public AlbumsController()
        {
            context = new IRunesDbContext();
        }

        public IHttpResponse Details(IHttpRequest request)
        {
            if (!request.Cookies.ContainsCookie(".auth"))
            {
                return new HtmlResult("<h1 style=\"color: red;\">You are not logged in.</h1>", HttpResponseStatusCode.BadRequest);
            }

            if (!request.QueryData.ContainsKey("id"))
            {
                return new HtmlResult("<h1 style=\"color: red;\">Invalid Id.</h1>", HttpResponseStatusCode.BadRequest);
            }

            string albumId = request.QueryData["id"].ToString();

            if (string.IsNullOrEmpty(albumId) || string.IsNullOrWhiteSpace(albumId))
            {
                return new HtmlResult("<h1 style=\"color: red;\">Invalid Id.</h1>", HttpResponseStatusCode.BadRequest);
            }

            var album = context.Albums.Include(x => x.Tracks).FirstOrDefault(x => x.Id == albumId);

            if (album == null)
            {
                return new HtmlResult("<h1 style=\"color: red;\">Invalid Id.</h1>", HttpResponseStatusCode.BadRequest);
            }

            string content = File.ReadAllText(PathToViews + "AlbumDetails.html");

            int startIndex = content.IndexOf("{{{");
            int endIndex = content.IndexOf("}}}");

            string template = content.Substring(startIndex, endIndex - startIndex + 3);

            List<string> templates = new List<string>();

            var tracks = album.Tracks.ToList();

            for (int i = 0; i < tracks.Count; i++)
            {
                string newTemplate = template;
                newTemplate = newTemplate.Replace("{{{", "");
                newTemplate = newTemplate.Replace("}}}", "");
                newTemplate = newTemplate.Replace("{{index}}", (i + 1).ToString());
                newTemplate = newTemplate.Replace("{{albumIdLink}}", albumId);
                newTemplate = newTemplate.Replace("{{trackId}}", tracks.ElementAt(i).Id);
                newTemplate = newTemplate.Replace("{{trackName}}", tracks.ElementAt(i).Name);

                templates.Add(newTemplate);
            }

            content = templates.Count > 0 ? content.Replace(template, string.Join("\r\n", templates)) 
                : content.Replace(template, string.Join("\r\n", "<h1>No tracks yet.</h1>"));

            string price = album.Tracks.Any() ? album.Price.ToString("F2") : "0.00";

            content = content.Replace("{{src}}", HttpUtility.UrlDecode(album.Cover));
            content = content.Replace("{{name}}", album.Name);
            content = content.Replace("{{price}}", price);
            content = content.Replace("{{albumId}}", album.Id);

            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }

        public IHttpResponse CreatePost(IHttpRequest request)
        {
            if (!request.Cookies.ContainsCookie(".auth"))
            {
                return new HtmlResult("<h1 style=\"color: red;\">You are not logged in.</h1>", HttpResponseStatusCode.BadRequest);
            }

            string name = request.FormData["name"].ToString();
            string cover = request.FormData["cover"].ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)
                || string.IsNullOrEmpty(cover) || string.IsNullOrWhiteSpace(cover))
            {
                return new HtmlResult("<h1 style=\"color: red;\">Invalid data</h1>", HttpResponseStatusCode.BadRequest);
            }

            Album album = new Album
            {
                Cover = cover,
                Name = name,
                Id = Guid.NewGuid().ToString()
            };

            context.Albums.Add(album);
            context.SaveChanges();

            return new RedirectResult("/Albums/All");
        }

        public IHttpResponse Create(IHttpRequest request)
        {
            if (!request.Cookies.ContainsCookie(".auth"))
            {
                return new HtmlResult("<h1 style=\"color: red;\">You are not logged in.</h1>", HttpResponseStatusCode.BadRequest);
            }

            string content = File.ReadAllText(PathToViews + "CreateAlbum.html");

            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }

        public IHttpResponse All(IHttpRequest request)
        {
            if (!request.Cookies.ContainsCookie(".auth"))
            {
                return new HtmlResult("<h1 style=\"color: red;\">You are not logged in.</h1>", HttpResponseStatusCode.BadRequest);
            }

            var albums = context.Albums.ToList();

            var content = File.ReadAllText(PathToViews + "AllAlbums.html");

            int startIndex = content.IndexOf("{{{");
            int endIndex = content.IndexOf("}}}");

            string template = content.Substring(startIndex, endIndex - startIndex + 3);

            List<string> templates = new List<string>();

            foreach (var album in albums)
            {
                string newTemplate = template;
                newTemplate = newTemplate.Replace("{{{", "");
                newTemplate = newTemplate.Replace("}}}", "");
                newTemplate = newTemplate.Replace("{{albumId}}", album.Id);
                newTemplate = newTemplate.Replace("{{albumName}}", album.Name);

                templates.Add(newTemplate);
            }

            content = templates.Count > 0 ? content.Replace(template, string.Join("\r\n", templates)) : 
                content.Replace(template, "<h1>No Albums yet</h1>");

            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }
    }
}
