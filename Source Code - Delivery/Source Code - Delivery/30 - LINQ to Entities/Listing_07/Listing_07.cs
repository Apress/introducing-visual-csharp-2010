using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using NorthwindModel;

class Listing_07 {

    static void Main(string[] args) {

        // create the compiled LINQ query
        Func<NorthwindEntities, string, IEnumerable<Employee>> compiledQuery =
            CompiledQuery.Compile(
            (NorthwindEntities contextParam, string cityParam) => 
                from e in contextParam.Employees
                where e.City == cityParam
                select e);

        // create a context 
        NorthwindEntities context = new NorthwindEntities();

        // define the set of cities we are interested in
        string[] cityNames = new string[] { "London", "Redmond", "Seattle" };

        // use the compiled query with each of the city names as parameters
        foreach (string city in cityNames) {
            IEnumerable<Employee> employees = compiledQuery(context, city);
            // print out the results
            Console.WriteLine("--- Employees in city: {0} ---", city);
            foreach (Employee emp in employees) {
                Console.WriteLine("{0} {1}", emp.FirstName, emp.LastName);
            }
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
