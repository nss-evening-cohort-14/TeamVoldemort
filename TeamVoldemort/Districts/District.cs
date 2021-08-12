using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamVoldemort.Districts
{
    class District
    {
        public string DistrictManager { get; set; }
        public DistrictName Name { get; set; }


        public District(string districtManager, DistrictName name)
        {
            DistrictManager = districtManager;
            Name = name;
        }
    }

}
