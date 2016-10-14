using System;
using System.Collections.Generic;
using System.Linq;

class Listing_18 {

    static void Main(string[] args) {

        List<string> myFruitList = new List<string>() {
            "apple", "plum", "cherry", "grape", "banana", "pear", "mango" , 
            "persimmon", "lemon", "lime", "coconut", "pineapple", "orange"};

        IEnumerable<IGrouping<char, string>> results = from e in myFruitList
                                                       group e by e[0];

        foreach (IGrouping<char, string> group in results) {
            Console.WriteLine("Group key: {0}", group.Key);
            foreach (string value in group) {
                Console.WriteLine("Group item: {0}", value);
            }
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}