namespace BusTicketsSystem.Client.Core.Contracts
{
    public interface ICommandInterpreter
    {
        string Read(string[] input);
    }
}
