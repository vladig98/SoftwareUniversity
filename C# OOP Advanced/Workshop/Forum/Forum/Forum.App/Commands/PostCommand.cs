using Forum.App.Contracts.Factories;
using Forum.App.Contracts.Models;
using Forum.App.Contracts.Services;
using System;

namespace Forum.App.Commands
{
    public class PostCommand : ICommand
    {
        private ISession session;
        private IPostService postService;
        private ICommandFactory commandFactory;

        public PostCommand(ISession session, IPostService postService, ICommandFactory commandFactory)
        {
            this.session = session;
            this.postService = postService;
            this.commandFactory = commandFactory;
        }

        public IMenu Execute(params string[] args)
        {
            int userId = session.UserId;

            string postTitle = args[0];
            string postCategory = args[1];
            string postContent = args[2];

            int postId = postService.AddPost(userId, postTitle, postCategory, postContent);

            session.Back();
            ICommand viewPostCommand = commandFactory.CreateCommand("ViewPostMenu");
            return viewPostCommand.Execute(postId.ToString());
        }
    }
}
