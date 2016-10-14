using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Listing_29 {

    static void Main(string[] args) {

        ArrayList myFruitList = new ArrayList() {
            "apple", "plum", "cherry", "grape", "banana", "pear", "mango" , 
            "persimmon", "lemon", "lime", "coconut", "pineapple", "orange"};

        // define the first query
        IEnumerable<string> results = from string e in myFruitList
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