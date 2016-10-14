using System;

class Listing_23 {

    static void Main(string[] args) {

        // create a string that has format items and 
        // escape sequences for brace characters
        string formatString = "My name is {{{0}}}";

        // use composite formatting
        Console.WriteLine(formatString, "Adam");

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}