using System;
using System.Collections.Generic;
using System.Linq;

class Listing_25 {

    static void Main(string[] args) {

        // create the data source
       List<string> myFruitList = new List<string>() {
            "apple", "plum", "cherry", "grape", "banana", "pear", "mango" , 
            "persimmon", "lemon", "lime", "coconut", "pineapple", "orange"};

        // define a variable that will be captured by the query
        char firstLetter = 'p';

        // define the LINQ query
        int resultCount = myFruitList
                          .Where(e => e[0] == firstLetter)
                          .Select(e => e).Count();

        // print out the results
        Console.WriteLine("Result count: {0}", resultCount);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}