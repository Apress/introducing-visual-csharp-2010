using System;

class Listing_10 {

    static void Main(string[] args) {

        // define a new string
        string myString = "Hello World";

        // use the string indexer and the Length property 
        // to enumerate the contents of the string
        for (int i = 0; i < myString.Length; i++) {
            Console.WriteLine("Character at position {0}: {1}", i ,myString[i]);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
