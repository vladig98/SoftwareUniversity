﻿using System.Collections.Generic;

namespace CarDealer.Models
{
    public class Part
    {
        public Part()
        {
            Cars = new HashSet<PartCar>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Supplier_Id { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<PartCar> Cars { get; set; }
    }
}
