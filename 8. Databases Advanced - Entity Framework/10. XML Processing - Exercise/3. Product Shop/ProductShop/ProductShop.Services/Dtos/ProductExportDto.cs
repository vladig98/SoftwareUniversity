using System.Xml.Serialization;

namespace ProductShop.Services.Dtos
{
    [XmlType("product")]
    public class ProductExportDto
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("price")]
        public decimal Price { get; set; }

        [XmlAttribute("buyer")]
        public string BuyerName { get; set; }
    }
}
