using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examChallenge
{
    public class LemonSoda
    {
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public LemonSoda(int price)
        {
            this.price = price;
        }
    }
}
