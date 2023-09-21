using System.Xml.Serialization;

namespace CarDealer.Services.Dtos
{
    [XmlType("car")]
    public class CarDto
    {
        [XmlElement("make")]
        public string Make { get; set; }

        [XmlElement("model")]
        public string Model { get; set; }

        [XmlElement("travelled-distance")]
        public ulong TraveledDistance { get; set; }
    }
}
