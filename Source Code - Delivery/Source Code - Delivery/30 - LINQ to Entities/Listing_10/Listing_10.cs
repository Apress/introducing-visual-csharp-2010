using System;
using System.Collections.Generic;
using System.Linq;
using NorthwindModel;

class Listing_10 {

    static void Main(string[] args) {

        // create a context 
        NorthwindEntities context = new NorthwindEntities();

        // STEP 1 - create the new Employee object
        Employee myNewEmployee = Employee.CreateEmployee(12345, "Freeman", "Adam");

        // STEP 2 - fill in some of the other details of the new object
        myNewEmployee.City = "London";
        myNewEmployee.Country = "UK";

        // STEP 3 - add the new object to the context collection for that type
        context.Employees.AddObject(myNewEmployee);

        // STEP 4 - save the changes to the database
        context.SaveChanges();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
