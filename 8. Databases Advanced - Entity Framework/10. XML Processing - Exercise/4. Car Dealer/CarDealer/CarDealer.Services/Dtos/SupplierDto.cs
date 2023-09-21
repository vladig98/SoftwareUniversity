using System.Xml.Serialization;

namespace CarDealer.Services.Dtos
{
    [XmlType("supplier")]
    public class SupplierDto
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("is-importer")]
        public bool IsImporter { get; set; }
    }
}
