namespace CarDealer.Services.Contracts
{
    public interface IDataExporterService
    {
        void ExportCarsWithDistance();
        void ExportCarsFromMakeFerrari();
        void ExportLocalSuppliers();
        void ExportCarsWithTheirListOfParts();
        void ExportTotalSalesByCustomer();
        void ExportSalesWithAppliedDiscount();
    }
}
