using System.Xml.Serialization;

namespace CarDealer.Services.Dtos
{
    [XmlType("supplier")]
    public class SupplierExportDto
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("parts-count")]
        public int PartsCount { get; set; }
    }
}
