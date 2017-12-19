using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examChallenge
{
    public class GrapeSoda
    {
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public GrapeSoda(int price)
        {
            Price = price;
        }
    }
}
