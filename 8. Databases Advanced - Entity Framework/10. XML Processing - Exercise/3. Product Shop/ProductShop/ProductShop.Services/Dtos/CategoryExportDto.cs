using System.Xml.Serialization;

namespace ProductShop.Services.Dtos
{
    [XmlType("category")]
    public class CategoryExportDto
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlElement("products-count")]
        public int NumberOfProducts { get; set; }

        [XmlElement("average-price")]
        public decimal AverageProductsPrice { get; set; }

        [XmlElement("total-revenue")]
        public decimal TotalRevenue { get; set; }
    }
}
