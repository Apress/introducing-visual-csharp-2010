using System;
using System.Collections.Generic;
using System.Linq;

class Listing_27 {

    static void Main(string[] args) {

        // create the data source
        List<string> myFruitList = new List<string>() {
            "apple", "plum", "cherry", "grape", "banana", "pear", "mango" , 
            "persimmon", "lemon", "lime", "coconut", "pineapple", "orange"};

        // define a variable that will be captured by the query
        char firstLetter = 'p';

        // define the LINQ query - leave out the aggregation part
        IEnumerable<string> results = myFruitList
                          .Where(e => e[0] == firstLetter)
                          .Select(e => e);

        //
        // do some other things....
        //

        // aggregate the results from the LINQ query by applying the Count
        // extension method to the query results - this will cause the query 
        // to be performed 
        int resultCount = results.Count();

        // print out the results
        Console.WriteLine("Result count: {0}", resultCount);

        // we can reuse the deferred part of the query again
        foreach (string str in results) {
            Console.WriteLine("Item: {0}", str);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}