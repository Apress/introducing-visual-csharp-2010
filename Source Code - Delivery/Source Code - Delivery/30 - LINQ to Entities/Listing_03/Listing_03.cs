using System;
using System.Linq;
using NorthwindModel;

class Listing_03 {

    static void Main(string[] args) {

        // create the context
        NorthwindEntities context = new NorthwindEntities();

        // get the first Order
        Order myOrder = context.Orders.First();

        // get the Employee associated with this order
        Employee myEmployee = myOrder.Employee;

        // print the details of the relationship
        Console.WriteLine("The order with ID {0} was created by {1} {2}",
            myOrder.OrderID, myEmployee.FirstName, myEmployee.LastName);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}