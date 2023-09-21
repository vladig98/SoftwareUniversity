using System.Xml.Serialization;

namespace CarDealer.Services.Dtos
{
    [XmlType("customer")]
    public class CustomerExportDto
    {
        [XmlAttribute("full-name")]
        public string Name { get; set; }

        [XmlAttribute("bought-cars")]
        public int BoughtCars { get; set; }

        [XmlAttribute("spent-money")]
        public decimal SpentMoney { get; set; }
    }
}
