using System;
using System.Collections.Generic;
using _01ConsoleApplicationChallenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class MenuItemsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            MenuItems menuItems = new MenuItems();
            menuItems.MealName = "Hamburger";
            menuItems.Description = "The best hamburger in the state!";
            menuItems.Price = 5;
            menuItems.MealNumber = 1;
            menuItems.Ingredients = "Hamburger";

            MenuRepositoryClass repo = new MenuRepositoryClass();
            repo.AddMenuItemsToList(menuItems);

            List<MenuItems> localList = repo.ReturnList();
            int actual = localList.Count;
        }
    }
}
    


