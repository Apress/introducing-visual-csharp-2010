using System;

class Listing_03 {

    static void Main(string[] args) {

        // use the hex prefix
        int hex = 0xFF;

        // explicitly specify a positive number
        short pos = +23;

        // explicitly specify a negative number
        short neg = -23;

        // print out the values
        Console.WriteLine("Hex: {0}", hex);
        Console.WriteLine("Pos: {0}", pos);
        Console.WriteLine("Neg: {0}", neg);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}