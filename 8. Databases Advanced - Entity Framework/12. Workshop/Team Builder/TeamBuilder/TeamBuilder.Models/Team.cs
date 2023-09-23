using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TeamBuilder.Models
{
    public class Team
    {
        public Team()
        {
            TeamEvents = new HashSet<TeamEvent>();
            UserTeams = new HashSet<UserTeam>();
            Invitations = new HashSet<Invitation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [MinLength(3)]
        public string Acronym { get; set; }
        public int CreatorId { get; set; }
        public User Creator { get; set; }

        public ICollection<TeamEvent> TeamEvents { get; set; }
        public ICollection<UserTeam> UserTeams { get; set; }
        public ICollection<Invitation> Invitations { get; set; }
    }
}
