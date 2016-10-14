using System;

class Listing_16 {

    static void Main(string[] args) {

        // define and populate the array
        string[] names = { "oranges", "apples", "guava", "peaches", "bananas", "grapes" };

        // define an Action delegate
        Action<string> act = new Action<string>(printItem);

        // enumerate the contents of the array using the delegate
        Array.ForEach(names, act);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    static void printItem(string param) {
        Console.WriteLine("Item: {0}", param);
    }
}