using System;
using System.Collections.Generic;

namespace TeamVoldemort.Employees
{
    class EmployeeRepository
    {
    static List<Employee> _employees = new List<Employee>
    {
    new Employee("Jim", PositionType.AssistantManager, 4312, 1),
    new Employee("Bob", PositionType.StoreManager, 5612, 1),
    new Employee("Roger", PositionType.AssistantManager, 3207, 2),
    new Employee("Shirley", PositionType.StoreManager, 7328, 2),
    };
    public static void GenerateEmployeeReport(int storeNumber)
    {
      {
        var counter = 1;
        foreach (var employee in _employees)
        {
          if (employee.StoreNumber == storeNumber)
          {
            var position = employee.EmployeeTitle;
            var name = employee.EmployeeName;
            var sales = employee.EmployeeSales;

            Console.WriteLine($"\t{counter}. {position}");
            Console.WriteLine($"\t{name}");
            Console.WriteLine($"\tRetail Sales: ${sales}");
            Console.WriteLine("                   ");
            counter++;
          }
        }
      }
    }
  }
}

