using System;

class Listing_13 {

    static void Main(string[] args) {

        double myDouble = 123.456;

        Console.WriteLine("Ceiling: {0}", Math.Ceiling(myDouble));
        Console.WriteLine("Floor: {0}", Math.Floor(myDouble));
        Console.WriteLine("Max from {0}, {1}: {2}", 10, 20, Math.Max(10, 20));
        Console.WriteLine("Min from {0}, {1}: {2}", 10, 20, Math.Min(10, 20));
        Console.WriteLine("Round: {0}", Math.Round(myDouble));
        Console.WriteLine("Truncate: {0}", Math.Truncate(myDouble));

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}