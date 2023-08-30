using System.Linq;
using Forum.App.Controllers.Contracts;
using Forum.App.Services;
using Forum.App.UserInterface;
using Forum.App.UserInterface.Contracts;
using Forum.App.UserInterface.Input;
using Forum.App.UserInterface.ViewModels;
using Forum.App.UserInterface.Views;

namespace Forum.App.Controllers
{
    public class AddReplyController : IController
    {
        private const int TEXT_AREA_WIDTH = 37;
        private const int TEXT_AREA_HEIGHT = 6;
        private const int POST_MAX_LENGTH = 220;

        private static int centerTop = Position.ConsoleCenter().Top;
        private static int centerLeft = Position.ConsoleCenter().Left;

        private PostViewModel pvm;
        public ReplyViewModel Reply { get; private set; }

        private TextArea TextArea { get; set; }

        public bool Error { get; private set; }

        private enum Command
        {
            Write,
            Post,
            Back
        }

        public MenuState ExecuteCommand(int index)
        {
            switch ((Command)index)
            {
                case Command.Write:
                    TextArea.Write();
                    Reply.Content = TextArea.Lines.ToArray();
                    return MenuState.AddReply;
                case Command.Post:
                    bool validReply = PostService.TrySaveReply(Reply, pvm.PostId);
                    if (!validReply)
                    {
                        Error = true;
                        return MenuState.Rerender;
                    }
                    return MenuState.ReplyAdded;
                case Command.Back:
                    return MenuState.Back;
            }

            throw new InvalidCommandException();
        }

        public IView GetView(string userName)
        {
            Reply.Author = userName;
            return new AddReplyView(pvm, Reply, TextArea, Error);
        }

        public void SetPostId(int postId)
        {
            pvm = PostService.GetPostViewModel(postId);
            ResetReply();
        }

        public void ResetReply()
        {
            Error = false;
            Reply = new ReplyViewModel();
            int contentLength = pvm?.Content.Count ?? 0;
            TextArea = new TextArea(centerLeft - 18, centerTop + contentLength - 6,
                TEXT_AREA_WIDTH, TEXT_AREA_HEIGHT, POST_MAX_LENGTH);
        }

        public AddReplyController()
        {
            ResetReply();
        }

    }
}
