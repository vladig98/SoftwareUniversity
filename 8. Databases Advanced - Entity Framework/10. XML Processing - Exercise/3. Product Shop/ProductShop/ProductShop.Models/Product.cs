using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductShop.Models
{
    public class Product
    {
        public Product()
        {
            Categories = new HashSet<CategoryProduct>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }
        public int? BuyerId { get; set; }
        public User Buyer { get; set; }

        [Required]
        public int SellerId { get; set; }
        public User Seller { get; set; }

        public ICollection<CategoryProduct> Categories { get; set; }
    }
}
