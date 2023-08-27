namespace Forum.App.Contracts.Models
{
    public interface IButton : ILabel
    {
        bool IsField { get; }
    }
}
