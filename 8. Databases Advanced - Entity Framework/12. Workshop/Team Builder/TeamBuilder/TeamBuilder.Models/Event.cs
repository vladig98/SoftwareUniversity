﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TeamBuilder.Models
{
    public class Event
    {
        public Event()
        {
            ParticipatingEventTeams = new HashSet<TeamEvent>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CreatorId { get; set; }
        public User Creator { get; set; }

        public ICollection<TeamEvent> ParticipatingEventTeams { get; set; }
    }
}
