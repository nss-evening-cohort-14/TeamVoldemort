using System;
using TeamVoldemort.Menu;
using TeamVoldemort.Stores;

namespace TeamVoldemort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var menu = new DisplayMenu();
            var userInput =  menu.Display();
          while (userInput < 8)
         {
          menu.UserMenu(userInput);
          userInput = menu.Display();
         }

      }
    }
}
