using System;
using System.Collections.Generic;
using System.Linq;
using TeamVoldemort.Employees;

namespace TeamVoldemort.Stores
{
  class StoreRepository
  {
    //static List<Store> _stores = new List<Store>();
    //public List<Store> GetAllStores();
    static List<Store> _stores = new List<Store>()
  {
    new Store(1, "1037648", "96117", "1823294", "84445", "South"),
    new Store(2, "1682513.56", "76384.34", "1923829", "89563.77", "South")
  };

    public static void GenerateDistrictReport(string districtName)
    {
      {
        Console.Clear();
        Console.WriteLine($"District Sales Report: {districtName}");
        Console.WriteLine("                   ");
        foreach (var store in _stores)
        {
          if (store.DistrictStore == districtName)
          {
            var storeNumber = store.StoreNumber;
            var gasYearly = store.GasYearly;
            var gasCurrentQuarter = store.GasCurrentQuarter;

            var retailYearly = store.RetailYearly;
            var retailCurrentQuarter = store.RetailCurrentQuarter;

            Console.WriteLine($"Store #{storeNumber}");
            Console.WriteLine("---------------------------------------");
            EmployeeRepository.GenerateEmployeeReport(storeNumber);
            Console.WriteLine($"\tGas Yearly: ${gasYearly}");
            Console.WriteLine($"\tGas Current Quarter: ${gasCurrentQuarter}");
            Console.WriteLine($"\tRetail Yearly: ${retailYearly}");
            Console.WriteLine($"\tRetail Current Quarter: ${retailCurrentQuarter}");
            Console.WriteLine("                   ");
          }
        }
      }
    }

    public static void EnterStoreSales(int storeNumber)
    {
      foreach(var store in _stores)
      {
        if (store.StoreNumber == storeNumber)
        {
          Console.Clear();
          Console.WriteLine($"Entering Sales Report for Store #{storeNumber}");
          Console.WriteLine("                 ");
          Console.WriteLine("Enter Gas sales this year:");
          var newGasYearly = Console.ReadLine();

          Console.WriteLine("Enter Gas sales this quarter:");
          var newGasQuarterly = Console.ReadLine();

          Console.WriteLine("Enter Retail sales this year:");
          var newRetailYearly = Console.ReadLine();

          Console.WriteLine("Enter Retail sales this quarter:");
          var newRetailQuarterly = Console.ReadLine();

          store.GasYearly = newGasYearly;
          store.GasCurrentQuarter = newGasQuarterly;
          store.RetailYearly = newRetailYearly;
          store.RetailCurrentQuarter = newRetailQuarterly;

          Console.Clear();
          Console.WriteLine($"Sales for Store #{storeNumber}");
          Console.WriteLine("                 ");
          Console.WriteLine($"\tGas Yearly: ${store.GasYearly}");
          Console.WriteLine($"\tGas Current Quarter: ${store.GasCurrentQuarter}");
          Console.WriteLine($"\tRetail Yearly: ${store.RetailYearly}");
          Console.WriteLine($"\tRetail Current Quarter: ${store.RetailCurrentQuarter}");
          Console.WriteLine("                 ");

        }
      }
    }

    public static void AddStore()
    {
      Console.Clear();
      var userStore = new Store(100, "123", "456", "789", "282", "North");
      Console.WriteLine("Enter the store number");
      userStore.StoreNumber = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Enter Store District");
      userStore.DistrictStore = Console.ReadLine();

      Console.WriteLine("Enter Gas Current Year");
      userStore.GasYearly = Console.ReadLine();

      Console.WriteLine("Enter Gas Current Quarter");
      userStore.GasCurrentQuarter = Console.ReadLine();

      Console.WriteLine("Enter Retail Current Year");
      userStore.RetailYearly = Console.ReadLine();

      Console.WriteLine("Enter Retail Current Quarter");
      userStore.RetailCurrentQuarter = Console.ReadLine();

      _stores.Add(userStore);

      Console.WriteLine("        ");
      Console.WriteLine("New Store Created");
      Console.WriteLine("                 ");
      Console.WriteLine($"Sales for Store #{userStore.StoreNumber} in {userStore.DistrictStore} District");
      Console.WriteLine("                 ");
      Console.WriteLine($"\tGas Yearly: ${userStore.GasYearly}");
      Console.WriteLine($"\tGas Current Quarter: ${userStore.GasCurrentQuarter}");
      Console.WriteLine($"\tRetail Yearly: ${userStore.RetailYearly}");
      Console.WriteLine($"\tRetail Current Quarter: ${userStore.RetailCurrentQuarter}");
      Console.WriteLine("                 ");
    }
           
   }
}
