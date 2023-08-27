using Forum.App.Contracts.ViewModels;
using System;

namespace Forum.App.ViewModels
{
    public class ReplyViewModel : ContentViewModel, IReplyViewModel
    {
        public ReplyViewModel(string author, string content) : base(content)
        {
            Author = author;
        }

        public string Author { get; }
    }
}
