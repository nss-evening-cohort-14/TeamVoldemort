using System;
using System.Collections.Generic;

namespace TeamVoldemort.Store
{
    class StoreRepository
    {
        static List<Store> _stores = new List<Store>();
        // public List<Store> GetAllStores();
       
        public void addNewStore(int storeNumber, string gasYearly, string gasCurrentQuarter, string retailYearly, string retailCurrentQuarter, List<string> employeeList)
        {
            var newStore = new Store(storeNumber, gasYearly, gasCurrentQuarter, retailYearly, retailCurrentQuarter, employeeList);
            _stores.Add(newStore);
        }

        public StoreRepository()
        {

        }
    }
}
