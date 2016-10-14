using System;
using System.Collections.Generic;
using System.Linq;

class Listing_22 {

    static void Main(string[] args) {

        // create the data source
        List<string> myFruitList = new List<string>() {
            "apple", "plum", "cherry", "grape", "banana", "pear", "mango" , 
            "persimmon", "lemon", "lime", "coconut", "pineapple", "orange"};

        // define the LINQ query
        IEnumerable<string> results = myFruitList
                                      .Where(e => e[0] == 'p')
                                      .Select(e => e);

        // enumerate the results
        foreach (string str in results) {
            Console.WriteLine("Result: {0}", str);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}