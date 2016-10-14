using System;
using System.Collections.Generic;
using System.Linq;

class Listing_25 {

    static void Main(string[] args) {

        // create the data source
        List<string> myFruitNames
            = new List<string>() { "apple", "plum", "cherry", "grape" };

        // define a variable that will be captured by the query
        char firstLetter = 'a';

        // define the LINQ query
        IEnumerable<string> results = from e in myFruitNames
                                      where e[0] == firstLetter
                                      select e;

        // enumerate the results
        Console.WriteLine("--- First iteration ---");
        foreach (string str in results) {
            Console.WriteLine("Result: {0}", str);
        }

        // change the value assigned to the variable
        firstLetter = 'c';

        // enumerate the results again
        Console.WriteLine("--- Second iteration ---");
        foreach (string str in results) {
            Console.WriteLine("Result: {0}", str);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
