using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examChallenge
{
    public class SodaMachine
    {
        Inventory inventory = new Inventory(32, 24, 12);
        Cashbox cashbox = new Cashbox(20, 10, 20, 50);
        List<string> payment = new List<string>();
        public SodaMachine()
        {
        
        }
        //Console.ReadKey (1, 2, 3, 4) to trigger switch case calling appropriate function to add string of coins ("quarter", "dime", "nickel", "penny") to payment list, respectively. Console.ReadKey (enter) to submit payment.
        //Console.Ready (1, 2, 3) to trigger switch case calling functions from inventory & cashbox to dispense appropriate soda/dispense change, or refund, as appropriate
        public void AddQuarter()
        {
            payment.Add("Quarter");
        }
        public void AddDime()
        {
            payment.Add("Dime");
        }
        public void AddNickel()
        {
            payment.Add("Nickel");
        }
        public void AddPenny()
        {
            payment.Add("Penny");
        }
        public void AcceptPayment()
        {
            foreach (string coin in payment)
            {
                if (coin == "Quarter")
                {
                    cashbox.TransactionValue += cashbox.quarter.Worth;
                    cashbox.IncrementQuarterCount();
                }
                else if (coin == "Dime")
                {
                    cashbox.TransactionValue += cashbox.dime.Worth;
                    cashbox.IncrementDimeCount();
                }
                else if (coin == "Nickel")
                {
                    cashbox.TransactionValue += cashbox.nickel.Worth;
                    cashbox.IncrementDimeCount();
                }
                else if (coin == "Penny")
                {
                    cashbox.TransactionValue += cashbox.penny.Worth;
                    cashbox.IncrementPennyCount();
                }
            }
        }
        //deposit transaction (register value += transaction value)
        //if transacton value > respective inventory.soda.price, call decrement soda from inventory, refund = (transaction value - soda.price), if register != refund, void transaction, return payment, else if register > refund instance soda, dispense refund, decrement cashbox count, registeramount -= refund
        //else if transaction value = soda.price, call decrement soda, instance soda
        //else if transction value < soda.price, void transaction, return payment
    }
}
