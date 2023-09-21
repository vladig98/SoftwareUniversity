using System.Collections.Generic;
using System.Xml.Serialization;

namespace CarDealer.Services.Dtos
{
    [XmlType("car")]
    public class CPCarDto
    {
        [XmlAttribute("make")]
        public string Make { get; set; }

        [XmlAttribute("model")]
        public string Model { get; set; }

        [XmlAttribute("travelled-distance")]
        public ulong TraveledDistance { get; set; }

        [XmlArray("parts")]
        public HashSet<CPPartDto> Parts { get; set; }
    }
}
