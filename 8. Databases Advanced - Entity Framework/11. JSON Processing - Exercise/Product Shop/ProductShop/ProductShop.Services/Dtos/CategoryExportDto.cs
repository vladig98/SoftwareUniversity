namespace ProductShop.Services.Dtos
{
    public class CategoryExportDto
    {
        public string category { get; set; }
        public int productsCount { get; set; }
        public decimal averagePrice { get; set; }
        public decimal totalRevenue { get; set; }
    }
}
