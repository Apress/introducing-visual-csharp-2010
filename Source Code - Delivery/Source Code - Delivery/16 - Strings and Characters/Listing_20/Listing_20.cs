using System;

class Listing_20 {

    static void Main(string[] args) {

        string formatString = "My name is {0} and I live in {1}";

        Console.WriteLine(formatString, "Adam", "London");
        Console.WriteLine(formatString, "Jane", "New York");

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
