using System.Collections.Generic;

namespace ByTheCake.Models
{
    public class Product
    {
        public Product()
        {
            Orders = new HashSet<OrderProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public ICollection<OrderProduct> Orders { get; set; }
    }
}
