namespace Forum.App.Contracts.Models
{
    public interface ICommand
    {
        IMenu Execute(params string[] args);
    }
}
