using System;
using System.Collections.Generic;
using System.Linq;

class Listing_20 {

    static void Main(string[] args) {

        List<string> myFruitList = new List<string>() {
            "apple", "plum", "cherry", "grape", "banana", "pear", "mango" , 
            "persimmon", "lemon", "lime", "coconut", "pineapple", "orange"};

        var results = from e in myFruitList
                      group e by e[0] into fruitGroup
                      where fruitGroup.Count() > 1
                      orderby fruitGroup.Key
                      select fruitGroup;

        foreach (var group in results) {
            Console.WriteLine("--- Group Key: {0}", group.Key);
            foreach (string value in group) {
                Console.WriteLine("Item: {0}", value);
            }
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}