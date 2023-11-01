using Eventures.DbModels;
using Eventures.Models;

namespace Eventures.Services.Contracts
{
    public interface IUsersService
    {
        bool HasMoreThanOneAdmin();
        IQueryable<User> GetUsers();
        User CreateUserInstance(ExternalLoginViewModel model);
        User CreateUserInstance(RegisterViewModel model);
        Task Promote(User user);
        Task Demote(User user);
    }
}
