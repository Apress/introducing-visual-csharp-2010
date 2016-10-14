using System;

class Listing_08 {

    static void Main(string[] args) {

        try {

            try {

                // statements likely to cause exceptions

            } catch (Exception) {

                // handler statements
            }

            // more code statements

        } catch (Exception) {

            // handler statements for the outer try statement 
        }



        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

