using System;
using System.Collections.Generic;
using System.Linq;

class Listing_07 {

    static void Main(string[] args) {

        // define the collection
        var fruits = new string[] { "apple", "plum", "cherry", 
            "grape", "banana", "pear", "mango" , "persimmon", "lemon", 
            "lime", "coconut", "pineapple", "orange"};

        // define the query
        var results = from e in fruits
                      select e[0];

        // enumerate the results
        foreach (char c in results) {
            Console.WriteLine("Result item: {0}", c);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}