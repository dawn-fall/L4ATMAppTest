using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    internal class Program
    {
        //Global Variables
        public static string[] menuoptions = { "1", "2", "3", "4" };
        public static decimal balance;

        static void checkpin()
        {
            string pin = "";
            Console.WriteLine("\t**** Welcome to the ATM Program ****\n\n\tPlease enter your pin.");
            pin = Console.ReadLine();
            while (pin != "1234")
            {
                if (pin == "1234")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\tPin incorrect. Try again.");
                    pin = Console.ReadLine();
                }
            }
            Console.WriteLine("\tPin correct. Access granted.");
            mainmenu();

        }//end checkpin func

        static void mainmenu()
        {
            Console.WriteLine("********************************************\n");
            Console.WriteLine("\tPlease select an option:\n");
            Console.WriteLine("\t\t[1] View Balance");
            Console.WriteLine("\t\t[2] Withdraw Funds");
            Console.WriteLine("\t\t[3] Deposit Funds");
            Console.WriteLine("\t\t[4] Exit Program\n");
            Console.WriteLine("********************************************\n");
        }

        static void Main(string[] args)
        {
            checkpin();
        }
    }
}
