using System;
using System.Collections.Generic;
using System.Linq;

class Listing_02 {

    static void Main(string[] args) {

        string[] fruits = new string[] { "apple", "plum", "cherry", 
            "grape", "banana", "pear", "mango" , "persimmon", "lemon", 
            "lime", "coconut", "pineapple", "orange"};

        // define a parallel query using method syntax
        var parallelResults = fruits.AsParallel()
                                .Where(e => e[0] == 'p')
                                .Select(e => new {
                                    Name = e,
                                    Length = e.Length
                                });

        // enumerate the results
        foreach (var item in parallelResults) {
            Console.WriteLine("Result - Name: {0}, Length: {1}",
                item.Name, item.Length);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
