using System.Xml.Serialization;

namespace ProductShop.Services.Dtos
{
    [XmlRoot("users")]
    public class UPUsersExportDto
    {
        [XmlAttribute("count")]
        public int Count { get; set; }

        [XmlElement("user")]
        public UPUserExportDto[] users { get; set; }
    }
}
