using System;

class Listing_40 {

    static void Main(string[] args) {

        // print out the number of arguments
        Console.WriteLine("There are {0} arguments", args.Length);

        // enumerate the arguments
        foreach (string s in args) {
            Console.WriteLine("Argument: {0}", s);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}