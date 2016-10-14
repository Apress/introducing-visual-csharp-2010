using System;

class Listing_22 {

    static void Main(string[] args) {

        // specify the a string with a format item
        string formatString = "The cost of item {0} is {1, 3}";

        // use the composite formatting feature
        Console.WriteLine(formatString, 1, 100);
        Console.WriteLine(formatString, 2, 23);
        Console.WriteLine(formatString, 3, 1);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
