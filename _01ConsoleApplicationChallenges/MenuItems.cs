using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ConsoleApplicationChallenges
{
    
    
    public class MenuItems
    {
        public string MealName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int MealNumber { get; set; }
        public string Ingredients { get; set; }
        public MenuItems()
        {
        }
        public MenuItems(string mealName, string description, int price, int mealNumber, string ingredients)
        {
            MealName = mealName;
            Description = description;
            Price = price;
            MealNumber = mealNumber;
            Ingredients = ingredients;
        }
    }
    
       
     
}
