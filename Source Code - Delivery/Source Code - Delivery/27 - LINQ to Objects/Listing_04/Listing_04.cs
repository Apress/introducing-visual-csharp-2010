using System;
using System.Collections.Generic;
using System.Linq;

class Listing_04 {

    static void Main(string[] args) {

        List<string> myFruitList = new List<string>() {
            "apple", "plum", "cherry", "grape", "banana", "pear", "mango" , 
            "persimmon", "lemon", "lime", "coconut", "pineapple", "orange"};

        // define the first query
        IEnumerable<string> results = from e in myFruitList
                                      select e;

        // define a second query using the results from the 
        // first query as the data source
        IEnumerable<string> results2 = from e in results
                                       select e;

        // enumerate the results
        foreach (string str in results2) {
            Console.WriteLine("Result item: {0}", str);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
