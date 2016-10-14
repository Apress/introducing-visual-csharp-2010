using System;
using System.Collections.Generic;
using System.Linq;
using NorthwindModel;

class Listing_06 {

    static void Main(string[] args) {

        // create the context
        NorthwindEntities context = new NorthwindEntities();

        // perform a query
        IEnumerable<Order> results = from e in context.Orders
                                         .Include("Employee").Include("Customer")
                                     where e.Customer.Country == "UK"
                                     select e;

        // enumerate the results
        foreach (Order myOrder in results) {
            // print out the name of the order
            Console.WriteLine("Order ID: {0}, Customer Name: {1}",
                myOrder.OrderID, myOrder.Customer.CompanyName);

            // use the navgiation properties to get the employee
            Employee myEmployee = myOrder.Employee;
            Console.WriteLine("Order created by: {0} {1}",
                myEmployee.FirstName, myEmployee.LastName);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
