using System;

class Listing_06 {

    static void Main(string[] args) {

        for (int i = 0; i < 5; i++) {
            Console.WriteLine("Iteration for value: {0}", i);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}