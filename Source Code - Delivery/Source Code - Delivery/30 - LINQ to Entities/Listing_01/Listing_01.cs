using System;
using System.Linq;
using NorthwindModel;

class Listing_01 {

    static void Main(string[] args) {

        // create the context
        NorthwindEntities context = new NorthwindEntities();

        // query the database
        IQueryable<Employee> result = from e in context.Employees
                                      where e.City == "London"
                                      select e;

        // enumerate the results
        foreach (Employee e in result) {
            Console.WriteLine("Name: {0} {1}", e.FirstName, e.LastName);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}