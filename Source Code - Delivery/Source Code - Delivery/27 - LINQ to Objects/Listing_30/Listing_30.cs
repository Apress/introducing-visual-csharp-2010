using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Listing_30 {

    static void Main(string[] args) {

        ArrayList myFruitList = new ArrayList() {
            "apple", "plum", "cherry", "grape", "banana", "pear", "mango" , 
            "persimmon", "lemon", "lime", "coconut", "pineapple", "orange"};

        // use the Cast extension method to create an IEnumerable<string>
        IEnumerable<string> myEnum = myFruitList.Cast<string>();

        // define the query
        IEnumerable<string> results = from e in myEnum
                                      select e;

        // enumerate the results
        foreach (string str in results) {
            Console.WriteLine("Result item: {0}", str);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}