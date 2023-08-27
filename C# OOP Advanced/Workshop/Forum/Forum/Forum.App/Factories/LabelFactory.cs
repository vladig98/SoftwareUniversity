using Forum.App.Contracts.Factories;
using Forum.App.Contracts.Models;
using Forum.App.Models;

namespace Forum.App.Factories
{
    public class LabelFactory : ILabelFactory
    {
        public ILabel CreateLabel(string contents, Position position, bool isHidden = false)
        {
            return new Forum.App.Models.Label(contents, position, isHidden);
        }

        public IButton CreateButton(string contents, Position position, bool isHidden = false, bool isField = false)
        {
            return new Button(contents, position, isHidden, isField);
        }
    }
}
