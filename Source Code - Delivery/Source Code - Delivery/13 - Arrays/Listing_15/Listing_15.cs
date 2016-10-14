using System;

class Listing_15 {

    static void Main(string[] args) {

        // define and populate the array
        string[] names = { "oranges", "apples", "guava", "peaches", "bananas", "grapes" };

        // sort the array
        Array.Sort(names);

        // enumerate the contents of the (now sorted) array
        foreach (string s in names) {
            Console.WriteLine("Item: {0}", s);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}