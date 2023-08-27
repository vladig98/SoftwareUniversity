namespace Forum.App.Contracts.ViewModels
{
    public interface IReplyViewModel
    {
        string Author { get; }

        string[] Content { get; }
    }
}
