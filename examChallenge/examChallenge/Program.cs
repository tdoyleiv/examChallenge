using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examChallenge
{
    class Program
    {
        static void Main()
        {
            SodaMachine vendor = new SodaMachine();
            Console.WriteLine("\n\n\n\nThirsty? \n\n\nGrape Soda - 60 cents\n\nOrange Soda - 35 cents\n\nLemon Soda - 6 cents\n\nInsert coins before purchase\n\n\n\n\n");
            Console.WriteLine("\n\n\nPress (1) for Grape\n\nPress (2) for Orange\n\nPress (3) for Lemon");
            Console.ReadLine();
        }
    }
}
