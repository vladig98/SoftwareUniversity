using System.Collections.Generic;

namespace ProductShop.Services.Dtos
{
    public class UsersExportDto
    {
        public UsersExportDto()
        {
            soldProducts = new List<UPProductExportDto>();
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public List<UPProductExportDto> soldProducts { get; set; }
    }
}
