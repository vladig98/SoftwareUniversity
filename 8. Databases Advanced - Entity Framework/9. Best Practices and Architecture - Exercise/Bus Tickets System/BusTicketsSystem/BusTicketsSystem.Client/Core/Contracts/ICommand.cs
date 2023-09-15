namespace BusTicketsSystem.Client.Core.Contracts
{
    public interface ICommand
    {
        string Execute(string[] args);
    }
}
