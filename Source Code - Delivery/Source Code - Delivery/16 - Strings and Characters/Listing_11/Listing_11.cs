using System;

class Listing_11 {

    static void Main(string[] args) {

        // define a new string
        string myString = "Hello World";

        // enumerate the contents of the string with a foreach loop
        foreach (char c in myString) {
            Console.WriteLine("Character: {0}", c);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
