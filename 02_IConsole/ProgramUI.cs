using _02_KClaims;
using _02_KClaims_Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_IConsole
{
    class ProgramUI
    {
        private ClaimRepository _contentRepo = new ClaimRepository();
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
                Console.WriteLine("Select menu option:\n" +
                    "1. See all claims\n" +
                    "2. Take care of next claim\n" +
                    "3. Enter new claim\n" +
                    "4. Exit");

                //Get user input
                string input = Console.ReadLine();

                //Evualate the users input and act
                switch (input)
                {
                    case "1":
                        SeeAllClaims();
                        break;
                    case "2":
                        TakCareOfNextClaim();
                        break;
                    case "3":
                        EnterNewClaim();
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
        private void SeeAllClaims()
        {
            Console.Clear();
            ClaimClass newContent = new ClaimClass();

            //Option #1
            Console.WriteLine("Claim ID,Type Description Amount Date of Accident Date of Claim Is Valid");
            Console.WriteLine("1 Car, Car accident on 465,$400.00, 4.25.18, 4.27.18, true");
            Console.WriteLine("2, Home, House fire in Kitchen, $4000.00, 4/11/18 4/12/18, true");
            Console.WriteLine("3,Theft, Stolen pancakes, $4.00,4.27.18,6.1.18, false");
            Console.WriteLine("Press enter to move on to menu item #2");
            newContent.ClaimID = Console.ReadLine();

            //Option #2
            Console.WriteLine("ClaimID:1");
            Console.WriteLine("Type:Car");
            Console.WriteLine("Description");
            Console.WriteLine("Amount: $400");
            Console.WriteLine("Date of Accident: 4/25/18");
            Console.WriteLine("Date of Claim: 4/27/18");
            Console.WriteLine("True");
            Console.WriteLine("Do you want to deal with this claim now(y/n?");
            string isValidString = Console.ReadLine().ToLower();

            if (isValidString == "y")
            {
                newContent.IsValid = true;
            }
            else
            {
                newContent.IsValid = false;
            }

            _contentRepo.AddClaimToList(newContent);

            //Option #3
            Console.WriteLine("Please enter new data about the a claim as you will be prompted:");
            Console.WriteLine("Press any key to continue.");
            newContent.Description = Console.ReadLine();
            
            Console.WriteLine("Enter the claim ID");
            string ClaimAmountasstring = Console.ReadLine();
            newContent.ClaimAmount = double.Parse(ClaimAmountasstring);
            
            Console.WriteLine("Enter the claim type:");
            Console.ReadLine();
           
            Console.WriteLine("Enter a claim description:");
            Console.ReadLine();

            Console.WriteLine("Amount of damages:");
            Console.ReadLine();

            Console.WriteLine("Date of accident:");
            Console.ReadLine();

            Console.WriteLine("Date of claim:");
            Console.ReadLine();

            Console.WriteLine("Is this claim valid: y/n");
            Console.ReadLine();
        }

        private void DisplayAllContent()
        {

        }

        private void TakCareOfNextClaim()
        {

        }

        private void EnterNewClaim()
        {

        }
    }
}
