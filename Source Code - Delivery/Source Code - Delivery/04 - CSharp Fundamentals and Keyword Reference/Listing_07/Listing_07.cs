using System;

class Listing_07 {

    static void Main(string[] args) {

        // define an int array
        int[] array = { 2, 4, 6, 8, 10 };

        foreach (int i in array) {
            Console.WriteLine("Iteration for value: {0}", i);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}