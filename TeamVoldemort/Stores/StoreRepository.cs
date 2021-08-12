﻿using System;
using System.Collections.Generic;

namespace TeamVoldemort.Stores
{
  class StoreRepository
  {
    //static List<Store> _stores = new List<Store>();
    //public List<Store> GetAllStores();
    static List<Store> _stores = new List<Store>()
  {
    new Store(518, "1037648", "96117", "1823294", "84445", "Big South"),
    new Store(571, "1682513.56", "76384.34", "1923829", "89563.77", "Big South")
  };

    public static void GenerateDistrictReport(string districtName)
    {
      {
        Console.WriteLine("District Sales Report");
        foreach (var store in _stores)
        {
          if (store.DistrictName == districtName)
          {
            var storeNumber = store.StoreNumber;
            var gasYearly = store.GasYearly;
            var gasCurrentQuarter = store.GasCurrentQuarter;
            var retailYearly = store.RetailYearly;
            var retailCurrentQuarter = store.RetailCurrentQuarter;

            Console.WriteLine($"Store #{storeNumber}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Gas Yearly: ${gasYearly}");
            Console.WriteLine($"Gas Current Quarter: ${gasCurrentQuarter}");
            Console.WriteLine($"Retail Yearly: ${retailYearly}");
            Console.WriteLine($"Retail Current Quarter: ${retailCurrentQuarter}");
            Console.WriteLine("                   ");
          }
        }
      }
    }
           
   }
}
