using Forum.App.Services;
using Forum.Models;
using System.Collections.Generic;
using System.Linq;

namespace Forum.App.UserInterface.ViewModels
{
    public class ReplyViewModel
    {
        private const int LINE_LENGTH = 37;
        public string Author { get; set; }
        public IList<string> Content { get; set; }

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

        public ReplyViewModel(Reply reply)
        {
            Author = UserService.GetUser(reply.AuthorId).Username;

            Content = GetLines(reply.Content);
        }

        public ReplyViewModel()
        {
            Content = new List<string>();
        }
    }
}
