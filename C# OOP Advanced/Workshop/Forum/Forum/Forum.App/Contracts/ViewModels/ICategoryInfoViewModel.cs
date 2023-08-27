namespace Forum.App.Contracts.ViewModels
{
    public interface ICategoryInfoViewModel
    {
        int Id { get; }

        string Name { get; }

        int PostCount { get; }
    }
}
