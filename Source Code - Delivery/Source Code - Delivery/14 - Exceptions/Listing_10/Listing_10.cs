using System;

class Listing_10 {

    static void Main(string[] args) {

        try {
            // define a loval variable
            string myLocalVar = null;

            // try to so something with the local variable
            Console.WriteLine("First letter: {0}", myLocalVar[0]);

        } catch (Exception ex) {

            Console.WriteLine("Type: {0}", ex.GetType());
            Console.WriteLine("Message: {0}", ex.Message);
            Console.WriteLine("Stack: {0}", ex.StackTrace);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
