using System;
using TeamVoldemort.Menu;
using TeamVoldemort.Store;

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
          Console.WriteLine("You selected Generate District Report");
          break;
        case 3:
          Console.WriteLine("You selected Add New Employee");
          break;
        case 4:
          Console.WriteLine("You selected Add a Store/District");

                    var storeRepo = new StoreRepository();

                    Console.WriteLine("Enter store number:");
                    var storeNum = Console.ReadLine();
                    Console.WriteLine("Enter gas yearly sales:");
                    var storeGasYearly = Console.ReadLine();
                    Console.WriteLine("Enter gas sales for the current quarter:");
                    var storeGasCurrentQuarter = Console.ReadLine();
                    Console.WriteLine("Enter retail yearly sales:");
                    var storeRetailYearly = Console.ReadLine();
                    Console.WriteLine("Enter retail sales for the current quarter:");
                    var storeRetailCurrentQuarter = Console.ReadLine();

                    // still need employee list 

                    // storeRepo.addNewStore(storeNum, storeGasYearly, storeGasCurrentQuarter, storeRetailYearly, storeRetailCurrentQuarter);
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
