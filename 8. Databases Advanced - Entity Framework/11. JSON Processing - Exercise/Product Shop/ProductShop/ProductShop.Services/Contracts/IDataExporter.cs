namespace ProductShop.Services.Contracts
{
    public interface IDataExporter
    {
        void ExportProductsInRange();
        void ExportSuccessfullySoldProducts();
        void ExportCategoriesByProductsCount();
        void ExportUsersAndProducts();

    }
}
