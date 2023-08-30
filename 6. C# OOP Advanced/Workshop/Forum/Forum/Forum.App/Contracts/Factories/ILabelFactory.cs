using Forum.App.Contracts.Models;
using Forum.App.Models;

namespace Forum.App.Contracts.Factories
{
    public interface ILabelFactory
    {
        ILabel CreateLabel(string content, Position position, bool isHidden = false);

        IButton CreateButton(string content, Position position, bool isHidden = false, bool isField = false);
    }
}
