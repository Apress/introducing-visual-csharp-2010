using System;
using System.Collections.Generic;
using System.Linq;
using NorthwindModel;

class Listing_08 {

    static void Main(string[] args) {

        // create a context 
        NorthwindEntities context = new NorthwindEntities();

        // query the view
        IEnumerable<Customer_and_Suppliers_by_City> results
            = from e in context.Customer_and_Suppliers_by_Cities
              where e.City == "London" || e.City == "Paris"
              select e;

        // enumerate the results
        foreach (Customer_and_Suppliers_by_City item in results) {
            Console.WriteLine("Name: {0}, City: {1}",
                item.CompanyName,
                item.City);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
