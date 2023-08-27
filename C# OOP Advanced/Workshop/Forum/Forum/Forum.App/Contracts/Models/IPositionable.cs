using Forum.App.Models;

namespace Forum.App.Contracts.Models
{
    public interface IPositionable
    {
        Position Position { get; }
    }
}
