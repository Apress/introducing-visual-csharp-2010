using System;

class Listing_09 {

    static void Main(string[] args) {

        string[] names1 = { "oranges", "apples", "guava" };
        string[] names2 = { "pineapples", "cherries", "pears", "apricots" };

        printArrayContents(names1);
        printArrayContents(names2);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    static void printArrayContents(string[] arr) {
        for (int i = 0; i < arr.Length; i++) {
            Console.WriteLine("Array Item {0}: {1}", i, arr[i]);
        }
    }
}