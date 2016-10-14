using System;

class Listing_17 {

    static void Main(string[] args) {

        // define and populate the array
        string[] names = { "oranges", "apples", "guava", "peaches", "bananas", "grapes" };

        // enumerate the contents of the array using the delegate
        Array.ForEach(names, s => {
            Console.WriteLine("Item: {0}", s);
        });

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}