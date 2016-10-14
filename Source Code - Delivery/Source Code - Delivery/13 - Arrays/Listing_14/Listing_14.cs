using System;

class Listing_14 {

    static void Main(string[] args) {

        string[] names = { "oranges", "apples", "guava", "peaches", "bananas", "grapes" };

        foreach (string s in names) {
            Console.WriteLine("Checking...{0}", s);
            if (s.StartsWith("p")) {
                Console.WriteLine("Match! {0}", s);
                break;
            }
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}