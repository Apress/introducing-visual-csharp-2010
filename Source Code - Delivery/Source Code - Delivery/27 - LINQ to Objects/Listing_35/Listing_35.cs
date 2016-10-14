using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Listing_33 {

    static void Main(string[] args) {

        List<string> myFruitList 
            = new List<string>() {"apple", "plum", "cherry"};

        string[] mySizes = new string[] { "small", "medium", "large" };

        // define a LINQ query that has two range values
        var results = from fruit in myFruitList
                      from size in mySizes
                      select new {
                          Name = fruit,
                          Size = size
                      };

        // enumerate the results
        foreach (var item in results) {
            Console.WriteLine("Result - Name: {0}, Size: {1}",
                item.Name, item.Size);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}