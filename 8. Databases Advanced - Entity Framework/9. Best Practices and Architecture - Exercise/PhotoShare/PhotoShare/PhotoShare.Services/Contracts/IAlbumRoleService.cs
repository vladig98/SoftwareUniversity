using Microsoft.EntityFrameworkCore.Metadata;
using PhotoShare.Models;

namespace PhotoShare.Services.Contracts
{
    public interface IAlbumRoleService
    {
        AlbumRole PublishAlbumRole(int albumId, int userId, string role);

        TModel[] ByAlbumId<TModel>(int id);
        TModel[] ByUserId<TModel>(int id);
        TModel[] ByAlbumName<TModel>(string name);
        TModel[] ByUserName<TModel>(string name);
    }
}
