using System;

class Listing_09 {

    static void Main(string[] args) {

        try {
            // define a loval variable
            string myLocalVar = null;

            // try to so something with the local variable
            Console.WriteLine("First letter: {0}", myLocalVar[0]);

        } catch (Exception ex) {
            Console.WriteLine("---Start of ToString() output---");
            Console.WriteLine(ex);
            Console.WriteLine("---End of ToString() output---");
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
