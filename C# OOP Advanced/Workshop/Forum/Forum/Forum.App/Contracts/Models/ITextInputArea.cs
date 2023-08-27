namespace Forum.App.Contracts.Models
{
    public interface ITextInputArea
    {
        string Text { get; }

        void Write();

        void Render();
    }
}
