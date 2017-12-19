using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examChallenge
{
    internal class Inventory
    {
        internal GrapeSoda grape = new GrapeSoda(60);
        internal OrangeSoda orange = new OrangeSoda(35);
        internal LemonSoda lemon = new LemonSoda(6);
        private int grapeCount;
        private int orangeCount;
        private int lemonCount;
        public int GrapeCount
        {
            get { return grapeCount; }
            set { grapeCount = value; }
        }
        public int OrangeCount
        {
            get { return orangeCount; }
            set { orangeCount = value; }
        }
        public int LemonCount
        {
            get { return lemonCount; }
            set { lemonCount = value; }
        }
        public Inventory(int grapeCount, int orangeCount, int lemonCount)
        {
            this.grapeCount = grapeCount;
            this.orangeCount = orangeCount;
            this.lemonCount = lemonCount;
        }
        public int IncrementGrapeCount()
        {
            return GrapeCount++;
        }
        public int IncrementOrangeCount()
        {
            return OrangeCount++;
        }
        public int IncrementLemonCount()
        {
            return lemonCount++;
        }
        public int DecrementGrapeCount()
        {
            return GrapeCount--;
        }
    }
}
