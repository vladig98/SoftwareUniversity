namespace BusTicketsSystem.Services.Contracts
{
    public interface ICustomerService
    {
        TModel ById<TModel>(int id);
        TModel ByName<TModel>(string name);
        bool Exist(int id);
        bool Exist(string name);
    }
}
