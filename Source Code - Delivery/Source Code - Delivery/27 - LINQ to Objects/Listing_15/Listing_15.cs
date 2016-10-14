using System;
using System.Collections.Generic;
using System.Linq;

class Listing_15 {

    static void Main(string[] args) {

        List<string> myFruitList = new List<string>() {
            "apple", "plum", "cherry", "grape", "banana", "pear", "mango" , 
            "persimmon", "lemon", "lime", "coconut", "pineapple", "orange"};

        IEnumerable<string> results = from e in myFruitList
                                      orderby e[0] descending
                                      select e;

        foreach (string item in results) {
            Console.WriteLine("Result item: {0}", item);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}