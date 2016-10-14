using System;
using System.Collections.Generic;
using System.Linq;
using NorthwindModel;

class Listing_09 {

    static void Main(string[] args) {

        // create a context 
        NorthwindEntities context = new NorthwindEntities();

        // query the stored procedure
        IEnumerable<Customers_By_City_Result> results =
            from e in context.Customers_By_City("London")
            where !e.ContactName.Contains("Hardy")
            select e;

        foreach (Customers_By_City_Result item in results) {
            Console.WriteLine("Name: {0}", item.CompanyName);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
