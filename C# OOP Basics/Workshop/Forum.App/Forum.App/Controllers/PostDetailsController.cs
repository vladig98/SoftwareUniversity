using Forum.App.Controllers.Contracts;
using Forum.App.Services;
using Forum.App.UserInterface;
using Forum.App.UserInterface.Contracts;
using Forum.App.UserInterface.ViewModels;
using Forum.App.UserInterface.Views;

namespace Forum.App.Controllers
{
    public class PostDetailsController : IController, IUserRestrictedController
    {
        public bool LoggedInUser { get; set; }
        public int PostId { get; set; }

        public IView GetView(string userName)
        {
            PostViewModel postViewModel = PostService.GetPostViewModel(PostId);
            return new PostDetailsView(postViewModel, LoggedInUser);
        }

        public void UserLogIn()
        {
            LoggedInUser = true;
        }

        public void UserLogOut()
        {
            LoggedInUser = false;
        }

        public void SetPostId(int postId)
        {
            PostId = postId;
        }

        public MenuState ExecuteCommand(int index)
        {
            switch ((Command)index)
            {
                case Command.AddReply:
                    return MenuState.AddReplyToPost;
                case Command.Back:
                    ForumViewEngine.ResetBuffer();
                    return MenuState.Back;
            }

            throw new InvalidCommandException();
        }

        private enum Command
        {
            Back,
            AddReply
        }
    }
}
