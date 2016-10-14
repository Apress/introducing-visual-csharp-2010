using System;
using System.Collections.Generic;
using System.Linq;
using NorthwindModel;

class Listing_12 {

    static void Main(string[] args) {

        // create a context 
        NorthwindEntities context = new NorthwindEntities();

        // query to find the empoyee record we are looking for
        IEnumerable<Employee> results = from e in context.Employees
                                        where e.LastName == "Freeman"
                                        select e;

        // enumerate the results and make changes
        foreach (Employee emp in results) {
            emp.City = "Boston";
            emp.Country = "USA";
            emp.Title = "Sales Representative";
            emp.ReportsTo = 2;
        }

    
        // save the changes
        context.SaveChanges();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
