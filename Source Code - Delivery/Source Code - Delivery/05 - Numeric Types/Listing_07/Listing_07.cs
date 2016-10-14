using System;

class Listing_07 {

    static void Main(string[] args) {

        checked {
            short s = 500;
            byte b = (byte)s;
            // print out the values
            Console.WriteLine("Original value: {0}", s);
            Console.WriteLine("Explicitly converted value: {0}", b);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}