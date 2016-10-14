using System;

class Listing_07 {

    static void Main(string[] args) {

        string firstString = "Introduction";
        string secondString = "to C#";

        if (firstString == secondString) {
            Console.WriteLine("Result of == operator: strings are the same");
        } else {
            Console.WriteLine("Result of == operator: strings are not the same");
        }

        if (firstString != secondString) {
            Console.WriteLine("Result of != operator: strings are different");
        } else {
            Console.WriteLine("Result of != operator: strings are not different");
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
