using System;
using System.Collections.Generic;
using System.Linq;

class Listing_04 {

    static void Main(string[] args) {

        string[] fruits = new string[] { "apple", "plum", "cherry", 
            "grape", "banana", "pear", "mango" , "persimmon", "lemon", 
            "lime", "coconut", "pineapple", "orange"};

        // define an ordered PLINQ query
        var parallelResults = from e in fruits.AsParallel()
                                  .AsOrdered()
                                  .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
                              where e[0] == 'p'
                              select new {
                                  Name = e,
                                  Length = e.Length
                              };

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
