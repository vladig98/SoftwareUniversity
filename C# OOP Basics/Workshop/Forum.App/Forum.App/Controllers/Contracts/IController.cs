using Forum.App.UserInterface.Contracts;

namespace Forum.App.Controllers.Contracts
{
    public interface IController
    {
        MenuState ExecuteCommand(int index);

        IView GetView(string userName);
    }
}
