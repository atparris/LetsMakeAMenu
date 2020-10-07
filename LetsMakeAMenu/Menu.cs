using System;
using System.Collections.Generic;
using System.Text;

namespace LetsMakeAMenu
{
    public class Menu
    {
        // what fields / variables will be located inside of our Menu?

        //private DateTime lastUpdated;


        // publically gettable, privately settable!!


        // what methods / functions will our Menu be able to use?

        /* public DateTime getLastUpdated()
        {
            return lastUpdated;
        } */

        public DateTime lastUpdated { get; private set; } // outside classes cannot edit lastUpdated because set is private!
        private List<MenuItem> myMenu;

        public Menu()
        {
            lastUpdated = DateTime.Now; // sets lastUpdated to current time
            myMenu = new List<MenuItem>(); // creates an empty list
        }

        public List<MenuItem> GetMenu()
        {
            return myMenu;
        }

        public void SetMenu(List<MenuItem> passedMenu)
        {
            myMenu = passedMenu;
        }

        
    }
}
