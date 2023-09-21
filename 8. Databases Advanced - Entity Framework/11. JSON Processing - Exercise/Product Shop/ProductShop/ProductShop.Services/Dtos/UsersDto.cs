using System.Collections.Generic;

namespace ProductShop.Services.Dtos
{
    public class UsersDto
    {
        public UsersDto()
        {
            users = new List<UPUsersDto>();
        }

        public int usersCount { get; set; }
        public List<UPUsersDto> users { get; set; }
    }
}
