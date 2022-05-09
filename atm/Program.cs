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
                    Console.WriteLine("Your input " + userInput + " is valid");
                }
                else
                {
                    Console.WriteLine("Your input " + userInput + " is not valid");
                }
                processmenu();
            } // end of while loop
        } // end checkinput func

        static void processmenu()
        {
            if(useroption == "1")
            {
                Console.WriteLine("\t[1] View Balance");
            }
            if (useroption == "2")
            {
                Console.WriteLine("\t[2] Withdraw Funds");
            }
            if (useroption == "3")
            {
                Console.WriteLine("\t[3] Deposit Funds");
            }
            if (useroption == "4")
            {
                Console.WriteLine("\t[4] Exit Program");
            }
        }//end processmenu func

        static void Main(string[] args)
        {
            checkpin();
        }
    }
}
