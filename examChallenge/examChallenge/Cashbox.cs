using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examChallenge
{
    internal class Cashbox
    {
        internal Quarter quarter = new Quarter(25);
        internal Dime dime = new Dime(10);
        internal Nickel nickel = new Nickel(5);
        internal Penny penny = new Penny(1);
        private int quarterCount;
        private int dimeCount;
        private int nickelCount;
        private int pennyCount;
        private int registerValue;
        private int transactionValue;
        public int RegisterValue
        {
            get { return GetRegisterValue(); }
        }
        public int TransactionValue
        {
            get { return transactionValue; }
            set { transactionValue = value}
        } 
        public int QuarterCount
        {
            get { return quarterCount; }
            set { quarterCount = value; }
        }
        public int DimeCount
        {
            get { return dimeCount; }
            set { dimeCount = value; }
        }
        public int NickelCount
        {
            get { return nickelCount; }
            set { nickelCount = value; }
        }
        public int PennyCount
        {
            get { return pennyCount; }
            set { pennyCount = value; }
        }
        public Cashbox(int quarterCount, int dimeCount, int nickelCount, int pennyCount)
        {
            this.quarterCount = quarterCount;
            this.dimeCount = dimeCount;
            this.nickelCount = nickelCount;
            this.pennyCount = pennyCount;
        }
        public int IncrementQuarterCount()
        {
            return QuarterCount++;
        }
        public int IncrementDimeCount()
        {
            return DimeCount++;
        }
        public int IncrementNickelCount()
        {
            return NickelCount++;
        }
        public int IncrementPennyCount()
        {
            return PennyCount++;
        }
        public int DecrementQuarterCount()
        {
            return QuarterCount--;
        }
        public int DecrementDimeCount()
        {
            return DimeCount--;
        }
        public int DecrementNickelCount()
        {
            return NickelCount--;
        }
        public int DecrementPennyCount()
        {
            return PennyCount--;
        }
        private int GetRegisterValue()
        {
            //register value += amounts of respective coins * respective worths
            return registerValue;
        }
    }
}
