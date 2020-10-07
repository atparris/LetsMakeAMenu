using System;
using System.Collections.Generic;
using System.Text;

namespace LetsMakeAMenu
{
    public class MenuItem
    {
        // what fields / variables will our MenuItem contain?
        private string name;
        private double price;
        private string description;
        private string category;
        private Boolean isNew;
        // private int pageNumber;
        // private string dietaryRestrictions;


        //private enum myDinners = { "lunch", "dinner", "breakfast"}; CAN BE USED FOR CATEGORY


        // what methods / functions will our MenuItems be able to use?

        public MenuItem(string passedName)
        {
            name = passedName;
            price = 0;
            description = "breakfast";
            category = "food";
            isNew = true;
        } 
        public MenuItem(string passedName, string passedDescription, double passedPrice = 20.00, Boolean passedIsNew = true)
        {
            name = passedName;
            price = passedPrice;
            description = passedDescription;
            isNew = passedIsNew;
        }


        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public double GetPrice()
        {
            return price;
        }




        /*public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public int MySecondProperty { get; set; }
        */
    }
}
