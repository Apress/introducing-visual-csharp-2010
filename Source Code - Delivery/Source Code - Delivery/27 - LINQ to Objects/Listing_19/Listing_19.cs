using System;
using System.Collections.Generic;
using System.Linq;

class Listing_19 {

    static void Main(string[] args) {

        List<string> myFruitList = new List<string>() {
            "apple", "plum", "cherry", "grape", "banana", "pear", "mango" , 
            "persimmon", "lemon", "lime", "coconut", "pineapple", "orange"};

        IEnumerable<IGrouping<bool, string>> results = from e in myFruitList
                                                       group e by e.Length > 5;

        foreach (IGrouping<bool, string> group in results) {
            if (group.Key) {
                Console.WriteLine("--- Names longer than 5 chars ---");
            } else {
                Console.WriteLine("--- Names 5 chars or less long ---");
            }

            foreach (string value in group) {
                Console.WriteLine("Item: {0}", value);
            }
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}