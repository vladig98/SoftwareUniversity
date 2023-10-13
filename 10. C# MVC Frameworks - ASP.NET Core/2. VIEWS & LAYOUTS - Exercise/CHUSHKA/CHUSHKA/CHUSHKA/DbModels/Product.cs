using CHUSHKA.DbModels.Enums;

namespace CHUSHKA.DbModels
{
    public class Product
    {
        public Product()
        {
            Orders = new List<Order>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public ProductType Type { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
