using CHUSHKA.DbModels;

namespace CHUSHKA.Models
{
    public class LoggedInViewModel
    {
        public LoggedInViewModel()
        {
            Products = new List<Product>();
        }

        public string Username { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
