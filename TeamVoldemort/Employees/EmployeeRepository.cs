using System;
using System.Collections.Generic;

namespace TeamVoldemort.Employees
{
    class EmployeeRepository
    {
    static List<Employee> _employees = new List<Employee>
    {
    new Employee("Jim", "AssistantManager", 4312, 1),
    new Employee("Bob", "Store Manager", 5612, 1),
    new Employee("Sarah", "Associate", 4586, 1),
    new Employee("Roger", "AssistantManager", 3207, 2),
    new Employee("Shirley", "Store Manager", 7328, 2),
    new Employee("Sarah", "Associate", 7328, 2),
    new Employee("Samantha", "AssistantManager", 3456, 3),
    new Employee("Rachel", "Store Manager", 5612, 3),
    new Employee("Kyle", "Associate", 3456, 3),
    new Employee("Cheyenne", "AssistantManager", 9375, 4),
    new Employee("Lilly", "Store Manager", 5612, 4),
    new Employee("Nick", "Associate", 3456, 4),




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
        public static void AddNewEmployee()
        {
            Console.Clear();
            var userEmployee = new Employee("Colin", "Associate", 4857, 1);

            Console.WriteLine("Enter Employee Name");
            userEmployee.EmployeeName = Console.ReadLine();

            Console.WriteLine("Enter Employee Title");
            userEmployee.EmployeeTitle = Console.ReadLine();

            Console.WriteLine("Enter Employee's Store Number");
            userEmployee.StoreNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Sales");
            userEmployee.EmployeeSales = Int32.Parse(Console.ReadLine());

            _employees.Add(userEmployee);


            Console.WriteLine("        ");
            Console.WriteLine("\tNew Employee Created");
            Console.WriteLine("                 ");
            Console.WriteLine($"\tName: {userEmployee.EmployeeName}");
            Console.WriteLine("                 ");
            Console.WriteLine($"\tStore: #{userEmployee.StoreNumber}");
            Console.WriteLine("                 ");
            Console.WriteLine($"\tTitle: {userEmployee.EmployeeTitle}");
            Console.WriteLine("                 ");
            Console.WriteLine($"\tEmployee Sales: ${userEmployee.EmployeeSales}");
            Console.WriteLine("                 ");


        }
    }
}

