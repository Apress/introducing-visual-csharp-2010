using System;

class Listing_10 {

    static void Main(string[] args) {

        // parse some different numeric types
        int i = int.Parse("-346");
        long l = long.Parse("957347");
        float f = float.Parse("400.145");

        try {
            // try to parse a null string
            int x = int.Parse(null);

        } catch (ArgumentNullException ex) {
            Console.WriteLine("--- First Exception ---");
            Console.WriteLine(ex.ToString());
        }

        try {
            // try to parse something which can't 
            // be converted into a number
            int x = int.Parse("Hello World");
        } catch (FormatException ex) {
            Console.WriteLine("--- Second Exception ---");
            Console.WriteLine(ex.ToString());
        }

        try {
            // try to parse a number which is too big
            // to be represented by the numeric type
            sbyte s = sbyte.Parse("500");
        } catch (OverflowException ex) {
            Console.WriteLine("---Third Exception ---");
            Console.WriteLine(ex.ToString());
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}