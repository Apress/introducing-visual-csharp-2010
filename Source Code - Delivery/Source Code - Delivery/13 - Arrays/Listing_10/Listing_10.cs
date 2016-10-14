using System;

class Listing_10 {

    static void Main(string[] args) {

        string[] names = { "oranges", "apples", "guava" };

        foreach (string str in names) {
            Console.WriteLine("Item: {0}", str);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}