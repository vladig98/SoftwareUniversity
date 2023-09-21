namespace ProductShop.Services.Contracts
{
    public interface IDataExporterService
    {
        void ExportProductsInRange();
        void ExportSoldProducts();
        void ExportCategoriesByProductsCount();
        void ExportUsersAndProducts();
    }
}
