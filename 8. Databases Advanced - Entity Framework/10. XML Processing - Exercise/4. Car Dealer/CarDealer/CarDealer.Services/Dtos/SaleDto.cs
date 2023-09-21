using System.Xml.Serialization;

namespace CarDealer.Services.Dtos
{
    [XmlType("sale")]
    public class SaleDto
    {
        [XmlElement("car")]
        public CarSaleDto Car { get; set; }

        [XmlElement("customer-name")]
        public string CustomerName { get; set; }

        [XmlElement("discount")]
        public decimal Discount { get; set; }

        [XmlElement("price")]
        public decimal Price { get; set; }

        [XmlElement("price-with-discount")]
        public decimal PriceWithDiscount { get; set; }
    }
}
