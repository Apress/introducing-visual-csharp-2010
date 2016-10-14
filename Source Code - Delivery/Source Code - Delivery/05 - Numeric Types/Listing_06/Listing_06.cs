using System;

class Listing_06 {

    static void Main(string[] args) {

        // define a short with a value greater than the 
        // byte type can hold
        short s = 500;

        // explicitly convert the short to a byte
        byte b = (byte)s;

        // print out the values
        Console.WriteLine("Original value: {0}", s);
        Console.WriteLine("Explicitly converted value: {0}", b);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}