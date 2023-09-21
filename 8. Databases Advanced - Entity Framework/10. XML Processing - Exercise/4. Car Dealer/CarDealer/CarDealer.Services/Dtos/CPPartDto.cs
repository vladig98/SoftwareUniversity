using System.Xml.Serialization;

namespace CarDealer.Services.Dtos
{
    [XmlType("part")]
    public class CPPartDto
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("price")]
        public decimal Price { get; set; }
    }
}
