using System.Collections.Generic;

namespace PhotoShare.Client.Core.Dtos
{
    public class UserFriendsDto
    {
        public UserFriendsDto()
        {
            Friends = new HashSet<FriendDto>();
        }

        public int Id { get; set; } 
        public string Username { get; set; }

        public ICollection<FriendDto> Friends { get; set; }
    }
}
