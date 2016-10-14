using System;

class Listing_15 {


    static void Main(string[] args) {

        try {

            try {

                // throw an exception
                throw new NullReferenceException();

            } catch (NullReferenceException ex) {
                Console.WriteLine("Inner try statement - Exception logged: {0}", ex.GetType());
                throw;
            }

        } catch (NullReferenceException ex) {
            // handle the exception
            Console.WriteLine("Outer try statement - Exception handled: {0}", ex.GetType());
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

