using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Listing_33 {

    static void Main(string[] args) {

        List<string> myFruitList = new List<string>() {
            "apple", "plum", "cherry", "grape", "banana", "pear", "mango" , 
            "persimmon", "lemon", "lime", "coconut", "pineapple", "orange"};

        
        // project a numeric type and then aggregate
        double projectResult = myFruitList.Select(e => e.Length).Average();

        // use the version of the Average method which selects inline
        double extensionResult = myFruitList.Average(e => e.Length);

        // print out the results
        Console.WriteLine("Projected Result: {0}", projectResult);
        Console.WriteLine("Extension Result: {0}", extensionResult);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}