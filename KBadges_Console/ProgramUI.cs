using KBadges_Repository;
using KomodoInsurance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBadges_Console
{
    class ProgramUI
    {
        private BadgeRepository _contentRepo = new BadgeRepository();
        public void Run()
        {
            Menu();
        }
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display options
                Console.WriteLine("Hello Security Admin, What would you like to do?\n" +
                    "1. Add a badge\n" +
                    "2. Edit a badge\n" +
                    "3. List all Badges\n" +
                    "4. Exit");

                //Get user input
                string input = Console.ReadLine();

                //Evualate the users input and act
                switch (input)
                {
                    case "1":
                        AddABadge();
                        break;
                    case "2":
                        EditABadge();
                        break;
                    case "3":
                        ListAllBadges();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }

                Console.WriteLine("Please Press any key to be taken back to the main menu.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void AddABadge()
        {
            Console.Clear();
            Badges newContent = new Badges();

            //#1 Add a Badge
            Console.WriteLine("What is the number to the badge?");
            Console.ReadLine();
            Console.WriteLine("List a door that it needs access to?");
            Console.ReadLine();
            Console.WriteLine("Any other doors (y/n)?");
            Console.ReadLine();
            
        }
        private void EditABadge()
        {
            Console.Clear();
            Badges newContent = new Badges();

            //Edit a Badge
            Console.WriteLine("What is the badge number to update?");
            Console.ReadLine();
            Console.WriteLine("Badge# 12345 has access to doors A5 & A7, please press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Press #1 to remove a door or press #2 to add a door, what would you like to do?");
            Console.ReadLine();
            Console.WriteLine("Which door would you like to remove?");
            Console.ReadLine();
            Console.WriteLine("Door A5 has been removed.  Badge #12345 only has access to door A7.");
            
        }
        private void ListAllBadges()
        {
            //List all view
            Console.Clear();
            Badges newContent = new Badges();

            Console.WriteLine("Key Badge #12345 has access to A7");
            Console.WriteLine("Key Badge #22345 has access to A1,A4,,B1,B2");
            Console.WriteLine("Key Badge 32345 has access to A4,A5");
            
        }
    }
}
