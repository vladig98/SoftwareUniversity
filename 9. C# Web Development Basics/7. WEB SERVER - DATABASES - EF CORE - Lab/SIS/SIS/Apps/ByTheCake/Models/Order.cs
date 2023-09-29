using System;
using System.Collections.Generic;

namespace ByTheCake.Models
{
    public class Order
    {
        public Order()
        {
            Products = new HashSet<OrderProduct>();
        }

        public int Id { get; set; }
        public DateTime DateOfCreation { get; set; }
        public ICollection<OrderProduct> Products { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
