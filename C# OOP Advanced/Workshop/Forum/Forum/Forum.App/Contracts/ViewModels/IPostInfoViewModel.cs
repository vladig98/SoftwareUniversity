namespace Forum.App.Contracts.ViewModels
{
    public interface IPostInfoViewModel
    {
        int Id { get; }

        string Title { get; }

        int ReplyCount { get; }
    }
}
