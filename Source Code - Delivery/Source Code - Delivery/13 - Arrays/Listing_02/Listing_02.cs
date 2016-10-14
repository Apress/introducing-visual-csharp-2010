using System;

class Listing_02 {

    static void Main(string[] args) {

        // define the product names in an array
        string[] names = { "oranges", "apples", "guava", "cherry", "strawberry" };

        // select the product names > six chars
        CheckLengthAndPrintNames(names);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    static void CheckLengthAndPrintNames(string[] names) {
        foreach (string name in names) {
            if (name.Length > 5) {
                Console.WriteLine("Item: {0}", name);
            }
        }
    }
}

