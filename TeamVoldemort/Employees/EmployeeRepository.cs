using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamVoldemort.Employees
{
    class EmployeeRepository
    {
        static List<Employee> _employees = new List<Employee>
    {
    new Employee("Jim", 1, "AssistantManager", 4312, 1),
    new Employee("Bob", 2, "Store Manager", 5612, 1),
    new Employee("Sarah", 3, "Associate", 4586, 1),
    new Employee("Roger", 4, "AssistantManager", 3207, 2),
    new Employee("Shirley", 5, "Store Manager", 7328, 2),
    new Employee("Sarah", 6, "Associate", 7328, 2),
    new Employee("Samantha", 7, "AssistantManager", 3456, 3),
    new Employee("Rachel", 8, "Store Manager", 5612, 3),
    new Employee("Kyle", 9, "Associate", 3456, 3),
    new Employee("Cheyenne", 10, "AssistantManager", 9375, 4),
    new Employee("Lilly", 11, "Store Manager", 5612, 4),
    new Employee("Nick", 12, "Associate", 3456, 4),

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

        public static void generateEmployee(Employee userEmployee)
        {
            Console.WriteLine("        ");
            Console.WriteLine("\tNew Employee Created");
            Console.WriteLine("                 ");
            Console.WriteLine($"\tName: {userEmployee.EmployeeName}");
            Console.WriteLine("                 ");
            Console.WriteLine($"\tID Number: {userEmployee.EmployeeID}");
            Console.WriteLine("                 ");
            Console.WriteLine($"\tStore: #{userEmployee.StoreNumber}");
            Console.WriteLine("                 ");
            Console.WriteLine($"\tTitle: {userEmployee.EmployeeTitle}");
            Console.WriteLine("                 ");
            Console.WriteLine($"\tEmployee Sales: ${userEmployee.EmployeeSales}");
            Console.WriteLine("                 ");
        }
        public static void AddNewEmployee()
        {
            Console.Clear();
            var userEmployee = new Employee("Colin", 13, "Associate", 4857, 1);

            Console.WriteLine("Enter Employee Name");
            userEmployee.EmployeeName = Console.ReadLine();

            Console.WriteLine("Enter Employee ID Number:");
            userEmployee.EmployeeID = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Title");
            userEmployee.EmployeeTitle = Console.ReadLine();

            Console.WriteLine("Enter Employee's Store Number");
            userEmployee.StoreNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Sales");
            userEmployee.EmployeeSales = Int32.Parse(Console.ReadLine());

            _employees.Add(userEmployee);
            generateEmployee(userEmployee);
        }

       

        public static void EnterTime()
    {
      Console.WriteLine("Please enter the Employee ID#:");
      var employeeToUpdate = Int32.Parse(Console.ReadLine());

      foreach (var empl in _employees)
      {
        Console.Clear();
        if (empl.EmployeeID == employeeToUpdate)
        {
          Console.WriteLine($"Entering Time for {empl.EmployeeName}");
          Console.WriteLine("     ");

          Console.WriteLine("Enter hours worked");
          var hoursWorked = Int32.Parse(Console.ReadLine());
          Console.WriteLine("     ");

          Console.WriteLine("Enter hourly pay rate");
          var rate = Int32.Parse(Console.ReadLine());
          Console.WriteLine("     ");

          var totalPay = hoursWorked * rate;
          empl.HoursWorked = hoursWorked;
          empl.PayRate = rate;


          Console.WriteLine($"Current Pay Report for {empl.EmployeeName}");
          Console.WriteLine($"-----------------------------");
          Console.WriteLine($"\t Total Hours Worked: {empl.HoursWorked}");
          Console.WriteLine($"\t Pay Rate: ${empl.PayRate}");
          Console.WriteLine($"\t Total Gross Pay: ${totalPay}");

          Console.WriteLine("     ");
          Console.WriteLine("Press Enter to exit");
          Console.ReadLine();
        }
      }
    }

    public static void PrintChecks()
    {
      Console.WriteLine("Please enter your Store #:");
      var storeToPrint = Int32.Parse(Console.ReadLine());

      foreach (var empl in _employees)
      {
        if (empl.StoreNumber == storeToPrint)
        {

          Console.WriteLine("     ");

          var totalPay = empl.HoursWorked * empl.HoursWorked;

          Console.WriteLine($"Current Pay Report for {empl.EmployeeName}");
          Console.WriteLine($"-----------------------------");
          Console.WriteLine($"\t Total Hours Worked: {empl.HoursWorked}");
          Console.WriteLine($"\t Pay Rate: ${empl.PayRate}");
          Console.WriteLine($"\t Total Gross Pay: ${totalPay}");

          Console.WriteLine("     ");
        }
      }
    }

        public static void RemoveEmployee()
        {

            Console.WriteLine("Enter Employee Id");
            var employeeSelected = int.Parse(Console.ReadLine());

            _employees.RemoveAll(employee => employee.EmployeeID == employeeSelected);
      Console.WriteLine($" Employee {employeeSelected} has been removed!");

      //foreach (var employee in _employees)
      //{
      //    if (employee.EmployeeID == employeeSelected)
      //    {

      //        _employees.Remove(employee);
      //        Console.WriteLine($" Employee {employeeSelected} has been removed!");
      //        return;
      //    }
      //}
    }
        public static void updateEmployeeInfo()
        {
            Console.WriteLine("Update employee information? Y/N");
            var response = Console.ReadLine().ToLower();
            var updating = true;

            if (string.Equals(response, "y"))
            {
                Console.WriteLine("Enter employee ID:");
                var employeeID = Int32.Parse(Console.ReadLine());
                foreach (var employee in _employees)
                {
                    if (employee.EmployeeID == employeeID)
                    {
                        while (updating)
                        {

                            Console.WriteLine("Select item to update: \n1. Name\n2. Sales\n3. Store\n4. Title");
                            var userResponse = Int32.Parse(Console.ReadLine());
                            switch (userResponse)
                            {
                                case 1:
                                    Console.WriteLine("Enter Employee Name:");
                                    employee.EmployeeName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter Employee Sales");
                                    employee.EmployeeSales = Int32.Parse(Console.ReadLine());
                                    break;
                                case 3:
                                    Console.WriteLine("Enter Employee's Store Number");
                                    employee.StoreNumber = Int32.Parse(Console.ReadLine());
                                    break;
                                case 4:
                                    Console.WriteLine("Enter Employee Title");
                                    employee.EmployeeTitle = Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("Select an available option");
                                    break;
                            }
                            generateEmployee(employee);

                            Console.WriteLine("Update another item? Y/N");
                            var answer = Console.ReadLine().ToLower();
                            if (String.Equals(answer, "y"))
                            {
                                updating = true;
                            }
                            else updating = false;
                        }
                    }
                }
            }
        }
    }
}

