using System;
using System.Collections.Generic;
using System.Linq;
using NorthwindModel;

class Listing_11 {

    static void Main(string[] args) {

        // create a context 
        NorthwindEntities context = new NorthwindEntities();

        // create the new customer
        Customer cust = new Customer {
            CustomerID = "LAWN",
            CompanyName = "Lawn Wranglers",
            ContactName = "Mr. Abe Henry",
            ContactTitle = "Owner",
            Address = "1017 Maple Leaf Way",
            City = "Ft. Worth",
            Region = "TX",
            PostalCode = "76104",
            Country = "USA",
            Phone = "(800) MOW-LAWN",
            Fax = "(800) MOW-LAWO"
        };

        // create the new order
        Order ord = new Order {
            CustomerID = "LAWN",
            EmployeeID = 4,
            OrderDate = DateTime.Now,
            RequiredDate = DateTime.Now.AddDays(7),
            ShipVia = 3,
            Freight = new Decimal(24.66),
            ShipName = "Lawn Wranglers",
            ShipAddress = "1017 Maple Leaf Way",
            ShipCity = "Ft. Worth",
            ShipRegion = "TX",
            ShipPostalCode = "76104",
            ShipCountry = "USA"
        };

        // attach the order to the customer
        cust.Orders.Add(ord);

        // add the new Customer 
        context.Customers.AddObject(cust);

        // save the changes
        context.SaveChanges();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
