using System.Collections.Generic;
using System.Xml.Serialization;

namespace ProductShop.Services.Dtos
{
    [XmlType("user")]
    public class UPUserExportDto
    {
        [XmlAttribute("first-name")]
        public string FirstName { get; set; }

        [XmlAttribute("last-name")]
        public string LastName { get; set; }

        [XmlAttribute("age")]
        public string Age { get; set; }

        [XmlElement("sold-products")]
        public UPProductsExportDto[] SoldProducts { get; set; }
    }
}
