using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductShop.Models
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<CategoryProduct>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string Name { get; set; }

        public ICollection<CategoryProduct> Products { get; set; }
    }
}
