# TeamVoldemort
Group Poject. Quick Trip

Console Project

> QuikTrip is one of the best gas stations on the planet and as a dev you've been asked to help the Account Manager and their department. It's becoming a hard task to keep track of the sales from the various regions and they need their district managers to enter their store sales and all employees information and individual sales.

> You and your group will need to create a console application with the following flow:

# User Interface

```
QuikTrip Management Systems

1. Enter District Sales
2. Generate District Report
3. Add New Employee
4. Add a Store/District
5. Exit
```

1. `Enter Store Number`

```
#518
```

2.  `Enter store sales`

```
Sales for Store #518

Gas Yearly: $1,037,648
Gas Current quarter: $96,117
Retail Yearly: $1,823,294
Retail Current quarter: $84,445
```

3.  `Generate Store Report`

```
District Sales Report

Store #518
------------------------------
1. Store Manager
	 Susie Marcos: 
		 Retail Sales: $4,234.20

2. Assistant Manager
	 Luke Devine
     Retail Sales: $4,083.94

3. Associate 
   Billie Steam
	    Retail Sales: $239.76

Gas Yearly: $1,037,648
Gas Current quarter: $96,117
Retail Yearly: $1,823,294
Retail Current quarter: $84,445

Store #571
------------------------------
1. Store Manager
	 Matty Braps: 
		 Retail Sales: $6,8237.23

2. Assistant Manager
	 Clifton
     Retail Sales: $4,083.94

3. Associate 
   Daniel Vans
	    Retail Sales: $1145.01

Gas Yearly: $1,682,513.56
Gas Current quarter: $76,384.34
Retail Yearly: $1,923,829
Retail Current quarter: $89,563.77
```

# Implementation Hints:

Create an **Employee** class which will be a *[base class](https://www.notion.so/Inheritance-Composition-8f6196ee85c4457aa5392338986312c7)* for different types of employees

- Get creative with the each class that inherit from Employee like a manager can create or promote associates

When creating a **District** 

- It is composed of a collection of **Store**
- Has one **District Manager**
- Has a District Name

A Store consists of a group of associates, store manager and assistant manager. *HINT*

## Example Repository Class

```csharp
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
		
		public List<Store> GetStores();

    {
        throw new NotImplementedException();
    }

}

```

Modularize your code. 

### ****Keep in mind the application should keep running until you press '5' to exit it....
