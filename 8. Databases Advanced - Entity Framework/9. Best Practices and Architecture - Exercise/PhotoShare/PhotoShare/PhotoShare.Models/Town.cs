﻿using System.Collections.Generic;

namespace PhotoShare.Models
{
    public class Town
    {
        public Town()
        {
            this.UsersBornInTown = new HashSet<User>();
            this.UsersCurrentlyLivingInTown = new HashSet<User>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public ICollection<User> UsersBornInTown { get; set; }

        public ICollection<User> UsersCurrentlyLivingInTown { get; set; }
    }
}
