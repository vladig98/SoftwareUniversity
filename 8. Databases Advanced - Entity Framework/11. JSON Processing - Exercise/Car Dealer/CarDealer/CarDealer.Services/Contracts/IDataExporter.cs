namespace CarDealer.Services.Contracts
{
    public interface IDataExporter
    {
        void ExportOrderedCustomers();
        void ExportCarsFromMakeToyota();
        void ExportLocalSuppliers();
        void ExportCarsWithTheirListOfParts();
        void ExportTotalSalesByCustomer();
        void ExportSalesWithAppliedDiscount();
    }
}
