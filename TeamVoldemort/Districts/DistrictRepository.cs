using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamVoldemort.Districts
{
    class DistrictRepository
        {
    // we're using a static list here instead of a proper database
    // but the general idea still holds up once we cover databases
    // it's just another piece of code to replace and refactor nbd
    static List<District> _districts = new List<District> {

             new District("Bob", "South"),
             new District("Terri", "North")
            };

        public List<District> GetAll()
        {
            return _districts;
        }

        // Adds New District
        public static void AddNewDistrict()
        {
            // Clears Console and creates a palceholder District //
            // This new district is set to the variable 'userDistrict' //
            Console.Clear();
            var userDistrict = new District("Jessica", "North");

            // Prompts user to enter district mamanger's name //
            // Sets the newly made district's 'DistrictManager' property to the user's input //
            Console.WriteLine("Enter the District Manager");
            userDistrict.DistrictManager = Console.ReadLine();

            // Propmts user to enter district location //
            // Sets the newly made district's 'Name' property to the user's input //
            Console.WriteLine("Enter District Location");
            userDistrict.Name = Console.ReadLine();

            // Used .Add to add this new 'userDistrict' to the '_districts' list in the 'DistrictRepository//
            _districts.Add(userDistrict);

            // Prints all info entered back to user and propmts them to finish filling out other info assosiated with the district //
            Console.WriteLine("        ");
            Console.WriteLine("New District Created");
            Console.WriteLine("                 ");
            Console.WriteLine($"{userDistrict.DistrictManager} is the District Manager of the {userDistrict.Name} District");
            Console.WriteLine("                 ");
            Console.WriteLine("To complete District details: Please add Stores, Employees, and Sales to your District. ");
        }
    }
}
