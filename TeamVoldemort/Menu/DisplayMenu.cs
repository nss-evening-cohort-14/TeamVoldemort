using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamVoldemort.Districts;
using TeamVoldemort.Employees;
using TeamVoldemort.Payroll;
using TeamVoldemort.Stores;

namespace TeamVoldemort.Menu
{
  class DisplayMenu
  {

    public int Display()
    {
      var outNumb = 9;
      var res = false;
      while(res == false)
      {
        Console.WriteLine("QuikTrip Management Systems");
        Console.WriteLine($"      ");

        Console.WriteLine("1. Enter District Sales");
        Console.WriteLine("2. Generate District Report");
        Console.WriteLine("3. Add New Employee");
        Console.WriteLine("4. Add a Store");
        Console.WriteLine("5. Add a District");
        Console.WriteLine("6. Payroll");
        Console.WriteLine("7. Exit");
        var result = Console.ReadLine();
        res = Int32.TryParse(result, out outNumb);
      }
      return outNumb;
      //int numb = 0;
      //var result = Console.ReadLine();
      // res = Int32.TryParse(result, out numb);
      // return Int32.Parse(result);

    }

    public void UserMenu(int userInput)
    {
      switch (userInput)
      {
        case 1:
          Console.WriteLine("You selected Enter District Sales");
          Console.WriteLine("Enter Store Number");
          var storeEntered = Int32.Parse(Console.ReadLine());
          StoreRepository.EnterStoreSales(storeEntered);
          break;
        case 2:
          Console.WriteLine("Please enter your district name");
          var userDistrict = Console.ReadLine();
          StoreRepository.GenerateDistrictReport(userDistrict);
          break;
        case 3:
          Console.WriteLine("You selected Add New Employee");
          EmployeeRepository.AddNewEmployee();
          break;
        case 4:
          StoreRepository.AddStore();
          break;
        case 5:
          Console.WriteLine("You selected Add New District");
          DistrictRepository.AddNewDistrict();
          break;
        case 6:
          var payRollSelection = PayRollMenu.ShowPayRollMenu();
          PayRollMenu.PayRollActions(payRollSelection);
          break;
        default:
          Console.WriteLine("Invalid Entry");
          break;
      }
    }

  }
}
