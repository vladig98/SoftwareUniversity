using PANDA.DbModels;

namespace PANDA.Models
{
    public class PackagesViewModel
    {
        public PackagesViewModel()
        {
            PendingPackages = new List<Package>();
            ShippedPackages = new List<Package>();
            DeliveredPackages = new List<Package>();
        }

        public ICollection<Package> PendingPackages { get; set; }
        public ICollection<Package> ShippedPackages { get; set; }
        public ICollection<Package> DeliveredPackages { get; set; }
    }
}
