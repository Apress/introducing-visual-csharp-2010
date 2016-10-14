using System;

class Listing_01 {

    static void Main(string[] args) {

        // define a loval variable
        string myLocalVar = null;

        // try to so something with the local variable
        Console.WriteLine("First letter: {0}", myLocalVar[0]);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

