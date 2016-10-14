using System;

class Listing_22 {

    static void Main(string[] args) {

        // define a func and implement it with an anonymous method
        Func<int, int, int> productFunction = delegate(int x, int y) {
            return x * y;
        };

        // invoke the func and get a result
        int result = productFunction(10, 20);

        // print out the result
        Console.WriteLine("Result: {0}", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}