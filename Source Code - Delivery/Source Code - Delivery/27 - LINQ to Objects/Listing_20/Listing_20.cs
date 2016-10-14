using System;
using System.Collections.Generic;
using System.Linq;

class Listing_20 {

    static void Main(string[] args) {

        List<string> myFruitList = new List<string>() {
            "apple", "plum", "cherry", "grape", "banana", "pear", "mango" , 
            "persimmon", "lemon", "lime", "coconut", "pineapple", "orange"};

        var results = from e in myFruitList
                      where e[0] == 'p' || e[0] == 'l'
                      group e by new {
                          FirstChar = e[0],
                          LengthGt5 = e.Length > 5
                      };

        foreach (var group in results) {
            Console.WriteLine("---Group Key - FirstChar: {0}, LengthGt5: {1}",
                group.Key.FirstChar, group.Key.LengthGt5);

            foreach (string value in group) {
                Console.WriteLine("Item: {0}", value);
            }
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}