using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using TeamBuilder.Models.Enums;

namespace TeamBuilder.Models
{
    public class User
    {
        public User()
        {
            UserTeams = new HashSet<UserTeam>();
            ReceivedInvitations = new HashSet<Invitation>();
            CreatedEvents = new HashSet<Event>();
            //CreatedUserTeams = new HashSet<UserTeam>();
        }

        public int Id { get; set; }

        [MinLength(3)]
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [MinLength(6)]
        public string Password { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<Event> CreatedEvents { get; set; }
        public ICollection<UserTeam> UserTeams { get; set; }
        public ICollection<UserTeam> CreatedUserTeams => UserTeams.Any() ? UserTeams.Where(x => x.UserId == x.Team.CreatorId).ToHashSet() : new HashSet<UserTeam>();
        public ICollection<Invitation> ReceivedInvitations { get; set; }
    }
}
