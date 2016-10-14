using System;

class Listing_01 {

    static void Main(string[] args) {

        // run the garbage collector
        GC.Collect();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
