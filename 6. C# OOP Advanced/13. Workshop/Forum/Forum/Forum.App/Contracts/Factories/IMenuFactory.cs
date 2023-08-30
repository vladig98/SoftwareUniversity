using Forum.App.Contracts.Models;

namespace Forum.App.Contracts.Factories
{
    public interface IMenuFactory
    {
        IMenu CreateMenu(string menuName);
    }
}
