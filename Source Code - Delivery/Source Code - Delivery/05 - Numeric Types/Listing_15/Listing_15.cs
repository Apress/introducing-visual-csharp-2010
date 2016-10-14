using System;

class Listing_15 {

    static void Main(string[] args) {

        // define two large 32-bit ints
        int x = int.MaxValue;
        int y = int.MaxValue;

        // add them together and report on the result type
        Type t = (x + y).GetType();
        Console.WriteLine("Default result type: {0}", t);

        // add them together and assign the result to another int
        int result = x + y;
        Console.WriteLine("Int result: {0}", result);

        // cast them to long values
        long lresult = (long)x + (long)y;
        Console.WriteLine("Long result: {0}", lresult);

        try {
            // add the int values together, but do so 
            // in a checked block
            checked {
                int ofres = x + y;
                Console.WriteLine("Overflow result: {0}", ofres);
            }
        } catch (OverflowException ex) {
            Console.WriteLine("Caught exception of type: {0}", ex.GetType());
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}