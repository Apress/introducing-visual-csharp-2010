using System;

class Listing_08 {

    static void Main(string[] args) {

        string[] names = { "oranges", "apples", "guava" };

        for (int i = 0; i < 3; i++) {
            Console.WriteLine("Item: {0}", names[i]);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}