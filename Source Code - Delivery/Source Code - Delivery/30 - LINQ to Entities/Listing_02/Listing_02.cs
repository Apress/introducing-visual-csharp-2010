using System;
using System.Data.Objects.DataClasses;
using System.Linq;
using NorthwindModel;

class Listing_02 {

    static void Main(string[] args) {

        // create the context
        NorthwindEntities context = new NorthwindEntities();

        // get the first Employee using the First extension method
        Employee myEmployee = context.Employees.First();

        // get the orders associated with the employee
        EntityCollection<Order> myOrders = myEmployee.Orders;

        // enumerate the orders
        Console.WriteLine("There are {0} orders for employee: {1} {2}",
            myOrders.Count, myEmployee.FirstName, myEmployee.LastName);

        foreach (Order myOrder in myOrders) {
            Console.WriteLine("Order number: {0}", myOrder.OrderID);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}