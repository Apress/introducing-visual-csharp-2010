using System;

class Listing_21 {

    static void Main(string[] args) {

        // define and populate an array
        string[] names = { "oranges", "apples", "guava", "peaches", "bananas", "grapes" };

        // define the predicate
        Predicate<string> pred = new Predicate<string>(CheckString);

        // search for a match
        string match = Array.Find(names, pred);
        //string match = Array.Find(names, s => s.StartsWith("p"));

        // print the result
        Console.WriteLine("Match: {0}", match);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    static bool CheckString(string s) {
        return s.StartsWith("p");
    }
}