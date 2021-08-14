using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamVoldemort.Employees
{
    class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeTitle { get; set; }
        public int EmployeeSales { get; set; }
        public int StoreNumber { get; set; }
        public int PayRate { get; set; }
        public int HoursWorked { get; set; }

        public Employee(string employeeName, int employeeID, string employeeTitle, int employeeSales, int storeNumber)
        {
            EmployeeName = employeeName;
            EmployeeTitle = employeeTitle;
            EmployeeSales = employeeSales;
            StoreNumber = storeNumber;
            EmployeeID = employeeID;
        }

    }
}
