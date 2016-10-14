using System;

class Listing_28 {

    static void Main(string[] args) {

        // define and populate a rectangular array of strings
        string[,] namesArray = {
            {"apples", "oranges", "grapes", "pears"},
            {"green", "orange", "red", "green"}
        };

        Console.WriteLine("Enumerating using a foreach loop");
        foreach (string s in namesArray) {
            Console.WriteLine("Item: {0}", s);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}