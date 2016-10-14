using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Listing_31 {

    static void Main(string[] args) {

        ArrayList myNumbers = new ArrayList() {10, 20, 30, 40, "apple"};
            
        // use the Cast extension method to create an IEnumerable<string>
        IEnumerable<int> myEnum = myNumbers.OfType<int>();

        // define the query
        IEnumerable<int> results = from e in myEnum
                                      select e;

        // enumerate the results
        foreach (int val in results) {
            Console.WriteLine("Result item: {0}", val);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}