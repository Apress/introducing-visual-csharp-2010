using System;

class Listing_10 {

    static void Main(string[] args) {

        // create a new Random object
        Random myRNG = new Random();

        for (int i = 0; i < 5; i++) {
            Console.WriteLine("Value: {0}", myRNG.Next(100));
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}