using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examChallenge
{
    public class Dime
    {
        private int worth;
        public int Worth
        {
            get { return worth; }
            set { worth = value; }
        }
        public Dime(int worth)
        {
            Worth = worth;
        }
    }
}
