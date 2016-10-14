using System;
using System.Collections.Generic;
using System.Linq;

class Listing_01 {

    static void Main(string[] args) {

        string[] fruits = new string[] { "apple", "plum", "cherry", 
            "grape", "banana", "pear", "mango" , "persimmon", "lemon", 
            "lime", "coconut", "pineapple", "orange"};

        IEnumerable<string> results = from e in fruits 
                                      select e;

        foreach (string str in results) {
            Console.WriteLine("Result item: {0}", str);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}