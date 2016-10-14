using System;
using System.Collections.Generic;
using System.Linq;

class Listing_01 {

    static void Main(string[] args) {

        string[] fruits = new string[] { "apple", "plum", "cherry", 
            "grape", "banana", "pear", "mango" , "persimmon", "lemon", 
            "lime", "coconut", "pineapple", "orange"};

        // define a regular LINQ to Objects query
        var regularResults = from e in fruits
                             where e[0] == 'p'
                             select new {
                                 Name = e,
                                 Length = e.Length
                             };

        // enumerate the regular results
        Console.WriteLine("--- Regular LINQ Results ---");
        foreach (var item in regularResults) {
            Console.WriteLine("Result - Name: {0}, Length: {1}",
                item.Name, item.Length);
        }

        // define the same query using PLINQ
        var parallelResults = from e in fruits.AsParallel()
                              where e[0] == 'p'
                              select new {
                                  Name = e,
                                  Length = e.Length
                              };

        // enumerate the parallel results
        Console.WriteLine("--- Parallel LINQ Results ---");
        foreach (var item in parallelResults) {
            Console.WriteLine("Result - Name: {0}, Length: {1}",
                item.Name, item.Length);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
