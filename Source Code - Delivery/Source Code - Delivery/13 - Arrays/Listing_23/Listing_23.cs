using System;
using System.Collections.Generic;
using System.Linq;

class Listing_21 {

    static void Main(string[] args) {

        // define and populate an array including some null values
        string[] names = { "oranges", "apples", null, "guava", "peaches", null };

        IEnumerable<string> filtered = from s in names
                                       where s != null
                                       select s;

        string[] shrinkNames = filtered.ToArray();

        // print out the details of the array
        Console.WriteLine("Array length: {0}", shrinkNames.Length);
        foreach (string s in shrinkNames) {
            Console.WriteLine("Item: {0}", s);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}