﻿using System.Collections.Generic;

namespace CarDealer.Models
{
    public class Supplier
    {
        public Supplier()
        {
            Parts = new HashSet<Part>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsImporter { get; set; }
        public ICollection<Part> Parts { get; set; }
    }
}
