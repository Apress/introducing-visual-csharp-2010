using System;
using System.Collections.Generic;
using System.Linq;

class Listing_11 {

    static void Main(string[] args) {

        List<string> myFruitList = new List<string>() {
            "apple", "plum", "cherry", "grape", "banana", "pear", "mango" , 
            "persimmon", "lemon", "lime", "coconut", "pineapple", "orange"};

        var results = from e in myFruitList
                      select new {
                          Length = e.Length,
                          FirstChar = e[0]
                      };

        foreach (var item in results) {
            Console.WriteLine("Result item -  Length: {0}, FirstChar: {1}",
                item.Length, item.FirstChar);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}