using CHUSHKA.DbModels.Enums;
using System.ComponentModel.DataAnnotations;

namespace CHUSHKA.Models
{
    public class CreateProductViewModel
    {
        [Display(Name = "Name", Prompt = "Name...")]
        public string Name { get; set; }

        [Display(Name = "Price", Prompt = "Price...")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Display(Name = "Description", Prompt = "Description...")]
        public string Description { get; set; }

        [Display(Name = "Type", Prompt = "Type...")]
        public ProductType Type { get; set; }
    }
}
