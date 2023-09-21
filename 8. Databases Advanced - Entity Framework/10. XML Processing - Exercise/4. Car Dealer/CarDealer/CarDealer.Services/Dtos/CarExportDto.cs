using System.Xml.Serialization;

namespace CarDealer.Services.Dtos
{
    [XmlType("car")]
    public class CarExportDto
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("model")]
        public string Model { get; set; }

        [XmlAttribute("travelled-distance")]
        public ulong TraveledDistance { get; set; }
    }
}
