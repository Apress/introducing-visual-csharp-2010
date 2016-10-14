using System;

class Listing_25 {

    static void Main(string[] args) {

        // create a value-type
        int x = 100;

        // box the int as an object
        object myObject = x;

        // update the original value type
        x = 200;

        // unbox the int
        int unboxed = (int)myObject;

        // print out the values
        Console.WriteLine("Variable value: {0}", x);
        Console.WriteLine("Unboxed value: {0}", unboxed);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
