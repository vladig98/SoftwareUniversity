﻿using Forum.App.Services;
using Forum.Models;
using System.Collections.Generic;
using System.Linq;

namespace Forum.App.UserInterface.ViewModels
{
    public class PostViewModel
    {
        private const int LINE_LENGTH = 37;

        public PostViewModel()
        {
            Content = new List<string>();
        }

        public PostViewModel(Post post)
        {
            PostId = post.Id;
            Title = post.Title;
            Content = GetLines(post.Content);
            Author = UserService.GetUser(post.AuthorId).Username;
            Category = PostService.GetCategory(post.CategoryId).Name;
            Replies = PostService.GetPostReplies(post.Id);

        }

        public int PostId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Category { get; set; }

        public IList<string> Content { get; set; }

        public IList<ReplyViewModel> Replies { get; set; }

        private IList<string> GetLines(string content)
        {
            char[] contentChars = content.ToCharArray();
            IList<string> lines = new List<string>();

            for (int i = 0; i < content.Length; i += LINE_LENGTH)
            {
                char[] row = contentChars.Skip(i).Take(LINE_LENGTH).ToArray();
                string rowString = string.Join("", row);
                lines.Add(rowString);
            }

            return lines;
        }
    }
}
