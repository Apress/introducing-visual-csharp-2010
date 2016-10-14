using System;

class Listing_21 {

    static void Main(string[] args) {

        // define and populate an array including some null values
        string[] names = { "oranges", "apples", null, "guava", "peaches", null };

        // shrink the array by finding all of the items which are not null
        string[] shrinkNames = Array.FindAll(names, s => s != null);

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