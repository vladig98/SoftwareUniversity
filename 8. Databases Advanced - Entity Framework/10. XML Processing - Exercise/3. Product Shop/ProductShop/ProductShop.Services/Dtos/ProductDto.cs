using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace ProductShop.Services.Dtos
{
    [XmlType("product")]
    public class ProductDto
    {
        [XmlElement("name")]
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [XmlElement("price")]
        [Required]
        public decimal Price { get; set; }
    }
}
