using Forum.App.Contracts.Models;

namespace Forum.App.Contracts.Menus
{
    public interface ITextAreaMenu : IMenu
    {
        ITextInputArea TextArea { get; }
    }
}
