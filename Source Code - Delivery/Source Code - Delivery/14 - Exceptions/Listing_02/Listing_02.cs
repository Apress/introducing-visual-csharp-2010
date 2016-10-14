using System;

class Listing_02 {

    static void Main(string[] args) {

        // define a loval variable
        string myLocalVar = null;

        try {

            // try to so something with the local variable
            Console.WriteLine("First letter: {0}", myLocalVar[0]);

        } catch (NullReferenceException ex) {
            Console.WriteLine("Exception: {0}", ex.Message);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

