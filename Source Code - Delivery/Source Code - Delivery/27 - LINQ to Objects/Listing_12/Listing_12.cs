using System;
using System.Collections.Generic;
using System.Linq;

class Listing_12 {

    static void Main(string[] args) {

        List<string> myFruitList = new List<string>() {
            "apple", "plum", "cherry", "grape", "banana", "pear", "mango" , 
            "persimmon", "lemon", "lime", "coconut", "pineapple", "orange"};

        IEnumerable<bool> results = from e in myFruitList
                      select e.Length > 5;

        foreach (bool item in results) {
            Console.WriteLine("Result item: {0}", item);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}