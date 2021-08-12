using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamVoldemort.Districts;

namespace TeamVoldemort.Stores
{
    class Store
    {
        public StoreNumberEnum StoreNumber { get; set; }
        public string GasYearly { get; set; }
        public string GasCurrentQuarter { get; set; }
        public string RetailYearly { get; set; }
        public string RetailCurrentQuarter { get; set; }
        public DistrictName DistrictName { get; set; }
        

        public Store(StoreNumberEnum storeNumber, string gasYearly,string gasCurrentQuarter, string retailYearly, string retailCurrentQuarter, DistrictName districtName)
        {
            StoreNumber = storeNumber;
            GasYearly = gasYearly;
            GasCurrentQuarter = gasCurrentQuarter;
            RetailYearly = retailYearly;
            RetailCurrentQuarter = retailCurrentQuarter;
            DistrictName = districtName;
        }
    }
}
