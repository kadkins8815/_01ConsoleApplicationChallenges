using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _01ConsoleApplicationChallenges
{
    public class MenuRepositoryClass
    {
        List<MenuItems> _listOfMenuItems = new List<MenuItems>();
        public void AddMenuItemsToList(MenuItems menuitemsObject)
        {
            _listOfMenuItems.Add(menuitemsObject);
        }
        public List<MenuItems> ReturnList()
        {
            return _listOfMenuItems;
        }
        



        
        //Program UI
       
        //console app
        //A description
        //Menurepository
        //A price
        //ProgrmaUI
    }
}
