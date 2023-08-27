using Forum.App.Contracts.Models;

namespace Forum.App.Contracts.Factories
{
    public interface ICommandFactory
    {
        ICommand CreateCommand(string commandName);
    }
}
