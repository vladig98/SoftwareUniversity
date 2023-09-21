using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace ProductShop.Services.Dtos
{
    [XmlType("category")]
    public class CategoryDto
    {
        [XmlElement("name")]
        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string Name { get; set; }
    }
}
