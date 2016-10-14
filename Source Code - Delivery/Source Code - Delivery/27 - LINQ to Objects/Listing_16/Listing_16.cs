using System;
using System.Collections.Generic;
using System.Linq;

class Listing_16 {

    static void Main(string[] args) {

        List<string> myFruitList = new List<string>() {
            "apple", "plum", "cherry", "grape", "banana", "pear", "mango" , 
            "persimmon", "lemon", "lime", "coconut", "pineapple", "orange"};

        var results = from e in myFruitList
                      where e[0] == 'p' && e.Length > 3
                      orderby e.Length
                      select new {
                          Name = e,
                          FirstChar = e[0],
                          Length = e.Length,
                      };

        foreach (var item in results) {
            Console.WriteLine("Result item - Name: {0}, First Char: {1}, Length: {2}",
                item.Name, item.FirstChar, item.Length);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}