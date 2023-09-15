using System;

namespace PhotoShare.Client.Core.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime? LastTimeLoggedIn { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
