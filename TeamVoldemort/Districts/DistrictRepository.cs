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

             new District("Bob", "South")

            };

        public List<District> GetAll()
        {
            return _districts;
        }

        static void AddNewDistrict(District district)
        {
            _districts.Add(district);
        }

        static void Delete(DistrictName name)
        {
            var districtToRemove = _districts.First(district => district.Name == name);

            _districts.Remove(districtToRemove);
        }
    }
}
