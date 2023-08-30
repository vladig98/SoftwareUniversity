using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    public class GoldenEditionBook : Book
    {
        public override decimal Price 
        {
            get
            {
                return base.Price;
            }
            set
            {
                base.Price = value * 1.3M;
            }
        }

        public GoldenEditionBook(string author, string title, decimal price):base(author, title, price)
        {

        }
    }
}
