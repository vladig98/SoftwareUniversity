using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace ProductShop.Services.Dtos
{
    [XmlType("user")]
    public class UserDto
    {
        [XmlAttribute("firstName")]
        public string FirstName { get; set; }

        [XmlAttribute("lastName")]
        [Required]
        [MinLength(3)]
        public string LastName { get; set; }

        [XmlIgnore]
        public int? age { get; set; }

        [XmlAttribute("age")]
        public string Age
        {
            get
            {
                return age.HasValue ? age.Value.ToString() : null;
            }
            set
            {
                age = string.IsNullOrEmpty(value) ? default(int?) : int.Parse(value);
            }
        }
    }
}
