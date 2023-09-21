using System.Xml.Serialization;

namespace ProductShop.Services.Dtos
{
    [XmlType("sold-products")]
    public class UPProductsExportDto
    {
        [XmlAttribute("count")]
        public int Count { get; set; }

        [XmlElement("product")]
        public UPProductExportDto[] Products { get; set; }
    }
}
