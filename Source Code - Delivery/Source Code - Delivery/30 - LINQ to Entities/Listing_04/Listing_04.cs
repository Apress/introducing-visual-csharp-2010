using System;
using System.Linq;
using NorthwindModel;

class Listing_04 {

    static void Main(string[] args) {

        // create the context 
        NorthwindEntities context = new NorthwindEntities();

        // perform a LINQ query that uses navigation properties
        var results = from e in context.Orders
                      where e.Employee.City == "London" && e.Customer.Country == "UK"
                      select new {
                          OrderID = e.OrderID,
                          EmployeeLastName = e.Employee.LastName,
                          CustomerName = e.Customer.CompanyName
                      };
  
        // enumerate the results
        foreach (var item in results) {
            Console.WriteLine("ID: {0} Name: {1} Customer: {2}",
                item.OrderID, item.EmployeeLastName, item.CustomerName);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
