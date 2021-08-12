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
      switch (userInput) 
      {
        case 1:
          Console.WriteLine("You selected Enter District Sales");
          break;
        case 2:
          StoreRepository.GenerateDistrictReport();
          menu.Display();
          break;
        case 3:
          Console.WriteLine("You selected Add New Employee");
          break;
        case 4:
          Console.WriteLine("You selected Add a Store/District");
          break;
        case 5:
          Console.WriteLine("You selected Exit");
          break;
        default:
          Console.WriteLine("Invalid Entry");
          break;
      }

    }
  }
}
