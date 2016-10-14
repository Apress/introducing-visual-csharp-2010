using System;
using System.Collections.Generic;
using System.Linq;
using NorthwindModel;

class Listing_13 {

    static void Main(string[] args) {

        // create a context 
        NorthwindEntities context = new NorthwindEntities();

        // query to find the empoyee record we are looking for
        IEnumerable<Employee> results = from e in context.Employees
                                        where e.LastName == "Freeman"
                                        select e;

        // enumerate the results and delete them
        foreach (Employee emp in results) {
            context.DeleteObject(emp);
        }

        // save the changes
        context.SaveChanges();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
