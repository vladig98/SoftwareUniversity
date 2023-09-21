using System.Collections.Generic;
using System.Xml.Serialization;

namespace ProductShop.Services.Dtos
{
    [XmlType("user")]
    public class UserExportDto
    {
        [XmlAttribute("first-name")]
        public string FirstName { get; set; }

        [XmlAttribute("last-name")]
        public string LastName { get; set; }

        [XmlArray("sold-products")]
        public HashSet<ProductDto> Products { get; set; }
    }
}
