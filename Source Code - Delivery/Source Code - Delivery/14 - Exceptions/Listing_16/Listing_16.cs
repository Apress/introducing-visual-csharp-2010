using System;
using System.Collections;

class Listing_16 {

    static void Main(string[] args) {

        try {

            try {

                // throw an exception
                throw new NullReferenceException();

            } catch (NullReferenceException ex) {
                // get the dictionary from the exception
                IDictionary d = ex.Data;
                // add some additional information to the exception
                d.Add("Additional Information", "This is some helpful state info");
                d.Add("More Information", "This is some extra helpful state info");

                // rethrow the exception
                throw;
            }

        } catch (NullReferenceException ex) {
            // handle the exception
            Console.WriteLine("Outer try statement - Exception handled: {0}", ex.GetType());
            // get the additional info
            IDictionary d = ex.Data;
            foreach (object o in d.Keys) {
                Console.WriteLine("Info: {0} = {1}", o, d[o]);
            }
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

