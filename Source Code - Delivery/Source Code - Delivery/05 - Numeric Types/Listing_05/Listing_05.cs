using System;

class Listing_05 {

    static void Main(string[] args) {

        // define a signed value
        int i = -200;
        // explicitly convert to an unsigned value
        uint ui = (uint)i;

        Console.WriteLine("Original Value: {0}", i);
        Console.WriteLine("Explicitly Converted Value: {0}", ui);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

