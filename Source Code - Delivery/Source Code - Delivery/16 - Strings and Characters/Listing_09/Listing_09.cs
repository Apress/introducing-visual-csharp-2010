using System;

class Listing_09 {

    static void Main(string[] args) {

        // define two local string variables
        string firstString = "Hello";
        string secondString = "World";

        // combine the strings with a string literal value
        // using the addition operator
        string combinedString = firstString + " " + secondString;

        // write the combined string to the console
        Console.WriteLine("Combined string: {0}", combinedString);
        
        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
