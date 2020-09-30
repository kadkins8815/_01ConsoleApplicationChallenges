using _01ConsoleApplicationChallenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ConsoleApp
{
    class ProgramUI
    {
        private readonly IConsole _console;
        private readonly MenuRepositoryClass _menuRepo = new MenuRepositoryClass();
        public ProgramUI(IConsole console)
        {
            _console = console;
        }
        public void Run()
        {
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            {
                //Meal name and Number for customer
                _console.WriteLine("Please choose a number below for your meal choice,included in the meal is a Water and Large Fries: \n" +
                    "1) The Basic Hamburger meal $4.99 \n" +
                    "2) The Basic CheeseBurger meal $6.99 \n" +
                    "3) The Ultimate Double Hamburger meal $7.99 \n" +
                    "4) The Ultimate Double CheeseBurger meal $8.99");

                string userInput = _console.ReadLine();


                //Condiments
                _console.WriteLine("Please select what condiments you would like on your burger: \n" +
                    "1) Mayo \n" +
                    "2) Ketchup \n" +
                    "3) Mustard \n" +
                    "4) Mayo,Ketchup and Mustard \n" +
                    "5) Mayo and Ketchup \n" +
                    "6) Mayo and Mustard \n" +
                    "7) Ketchup and Mustard");

                string Userinput = _console.ReadLine();

                //Toppings
                _console.WriteLine("Please select from the list of Toppings below: \n" +
                    "1) Lettuce \n" +
                    "2) Tomato \n" +
                    "3) Onions \n" +
                    "4) Lettuce,Tomato and Onions \n" +
                    "5) Lettuce and Tomato \n" +
                    "6) Onions and Tomato \n" +
                    "7) Onions and Lettuce");

                string Inputuser = _console.ReadLine();

                _console.WriteLine("Thank you for your order, it will be out shortly, press any key to exit the system.");
                Console.ReadLine();
            }
        }
    }    
}

