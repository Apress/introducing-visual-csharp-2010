using System;

class Listing_06 {

    static void Main(string[] args) {

        try {

            // statements likely to cause exceptions

        } catch (NullReferenceException ex) {

            Console.WriteLine("Message: {0}", ex.Message);

        } catch (ArgumentOutOfRangeException) {

            // code which handles a ArgumentOutOfRangeException

        } 

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

