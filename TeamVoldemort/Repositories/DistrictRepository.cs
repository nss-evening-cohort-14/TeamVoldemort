﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamVoldemort.Repositories
{
    class DistrictRepository
    {
        class DistrictRepository
        {
            // we're using a static list here instead of a proper database
            // but the general idea still holds up once we cover databases
            // it's just another piece of code to replace and refactor nbd
            static List<District> _districts = new List<District>();

            public List<District> GetDistricts()
            {
                throw new NotImplementedException();
            }

            public void SaveNewDistrict(District district)
            {
                throw new NotImplementedException();
            }
        }

        class StoreRepository
        {
            static List<Store> _stores = new List<Store>();
            public List<Store> GetAllStores();
        }

        class SalesRepository
        {
            static List<Sales> _sales = new List<Sales>();
            public List<Sales> GetAllSales();
        }

        class PeopleRepository
        {
            static List<Person> _people = new List<Person>
            {
                // Field for Employee Info //
            };
        }


    }
}
