using Forum.App.Contracts.Models;

namespace Forum.App.Contracts.Menus
{
    public interface IIdHoldingMenu : IMenu
    {
        void SetId(int id);
    }
}
