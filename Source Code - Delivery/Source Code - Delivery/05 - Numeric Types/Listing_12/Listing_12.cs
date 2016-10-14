using System;

class Listing_12 {

    static void Main(string[] args) {

        // define a decimal value
        decimal d = 12345.12345M;

        // call the various members and print out the results
        Console.WriteLine("Ceiling: {0}", decimal.Ceiling(d));
        Console.WriteLine("Floor: {0}", decimal.Floor(d));
        Console.WriteLine("Negate: {0}", decimal.Negate(d));
        Console.WriteLine("Round: {0}", decimal.Round(d));
        Console.WriteLine("Truncate: {0}", decimal.Truncate(d));

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}