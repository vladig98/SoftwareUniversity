using Forum.App.Contracts.Models;

namespace Forum.App.Contracts.Factories
{
    public interface ITextAreaFactory
    {
        ITextInputArea CreateTextArea(IForumReader reader, int x, int y, bool isPost = true);
    }
}
