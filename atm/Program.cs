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
        public static decimal balance = 0;
        public static string useroption = "";

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
            Console.WriteLine("\t[1] View Balance");
            Console.WriteLine("\t[2] Withdraw Funds");
            Console.WriteLine("\t[3] Deposit Funds");
            Console.WriteLine("\t[4] Exit Program\n");
            Console.WriteLine("********************************************\n");
            checkinput();
        }//end mainmenu func

        public static void checkinput()
        {
            bool check = false;
            while (check == false)
            {
                Console.WriteLine("Please choose an option ([1], [2], [3], [4])");
                string userInput = Console.ReadLine();
                useroption = userInput;
                // loop thru each item in the array (menuoptions) save each interation in the temp variable
                foreach (string temp in menuoptions)
                {
                    // check if users input equals what is in our array (now saved as temp variable)
                    // return true or return false save result into check.
                    check = userInput.Equals(temp);
                    // break out of the foreach loop if check = true
                    if (check)
                    {
                        break;
                    }
                } // end of foreach

                if (check)
                {
                    Console.WriteLine("\tYour input " + userInput + " is valid");
                }
                else
                {
                    Console.WriteLine("\tYour input " + userInput + " is not valid");
                }
                processmenu();
            } // end of while loop
        } // end checkinput func

        static void processmenu()
        {
            decimal amount;

            if(useroption == "1")
            {
                Console.WriteLine("\tYour Balance is " + "$" + balance);
                Console.WriteLine("\n\n");
                if(balance <= 0)
                {
                    Console.WriteLine("\tYou need to deposit some money.");
                }
                mainmenu();
            }
            if (useroption == "2")
            {
                Console.WriteLine("\tInput the amount to withdraw:");
                //amount to withdraw from balance
                if(decimal.TryParse(Console.ReadLine(), out amount) && balance > amount)
                {
                    balance -= amount;
                    Console.WriteLine("\tYou withdrew " + "$" + amount + ". Your balance is now " + "$" + balance + "\n");
                }
                else
                {
                    Console.WriteLine("\tInvalid input or Insufficient Funds.\n\n");
                }
                mainmenu();
            }
            if (useroption == "3")
            {
                Console.WriteLine("\tInput the amount to deposit:");
                //amount to deposit to balance
                if (decimal.TryParse(Console.ReadLine(), out amount))
                {
                    balance += amount;
                    Console.WriteLine("\tYou deposited " + "$" + amount + ". Your balance is now " + "$" + balance + "\n");
                }
                else
                {
                    Console.WriteLine("\tInvalid input.\n\n");
                }
                mainmenu();
            }
            if (useroption == "4")
            {
                Environment.Exit(0);
            }
        }//end processmenu func

        static void Main(string[] args)
        {
            checkpin();
        }
    }
}
