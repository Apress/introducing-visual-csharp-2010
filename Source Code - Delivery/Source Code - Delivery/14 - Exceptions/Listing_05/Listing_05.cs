using System;

class Listing_05 {

    static void Main(string[] args) {

        try {

            // statements likely to cause exceptions

        } catch (NullReferenceException ex) {

            // code which handles a NullReferenceException

        } catch (ArgumentOutOfRangeException ex) {

            // code which handles a ArgumentOutOfRangeException

        } catch (Exception ex) {

            // code which handles all exception types not handled
            // in the clauses above

        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

