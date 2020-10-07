using System;

namespace LetsMakeAMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            //MenuItem randomItem = new MenuItem(5);

            MenuItem randomItem = new MenuItem("Steak", "Entree", 19.99);

            Menu myMenu = new Menu();

            // myMenu.Add(randomItem);

            //Console.WriteLine(randomItem.name); // public name

            //randomItem.name = "new name"; // public name

            randomItem.GetName(); // private name
            randomItem.GetPrice(); // private price


            Console.WriteLine(randomItem.GetPrice());

            // MenuItem.name = "dessert item";
        }
    }
}
