using System;
using System.Collections.Generic;
using System.Linq;

class Listing_05 {

    static void Main(string[] args) {

        string[] fruits = new string[] { "apple", "plum", "cherry", 
            "grape", "banana", "pear", "mango" , "persimmon", "lemon", 
            "lime", "coconut", "pineapple", "orange"};

        // use the ForAll extension method
        fruits.AsParallel()
            .Where(e => e[0] == 'p')
            .ForAll(e => Console.WriteLine("Result: {0}", e));

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
