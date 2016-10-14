using System;
using System.Collections.Generic;
using System.Linq;

class Listing_05 {

    static void Main(string[] args) {

        // define the collection
        string[] fruits = new string[] { "apple", "plum", "cherry", 
            "grape", "banana", "pear", "mango" , "persimmon", "lemon", 
            "lime", "coconut", "pineapple", "orange"};

        // define the query
        IEnumerable<char> results = from e in fruits
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
