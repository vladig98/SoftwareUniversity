using Forum.App.Contracts.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Forum.App.ViewModels
{
    public class PostViewModel : ContentViewModel, IPostViewModel
    {
        public PostViewModel(string title, string author, string content, IEnumerable<IReplyViewModel> replies) : base(content)
        {
            Title = title;
            Author = author;
            Replies = replies.ToArray();
        }

        public string Title { get; }

        public string Author { get; }

        public IReplyViewModel[] Replies { get; }
    }
}
