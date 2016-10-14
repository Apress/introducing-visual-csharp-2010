using System;

class Listing_25 {

    static void Main(string[] args) {

        // implement an anonymous method that multiplies ints
        Func<int, int, int> anonFunc = delegate(int x, int y) {
            return x * y;
        };

        // do the same thing with a lambda expression
        Func<int, int, int> lambaFunc = (x, y) => {
            return x * y;
        };

        lambaFunc = (int x, int y) => x * y;

        // invoke the delegates
        Console.WriteLine("Anonymous Method Result: {0}", anonFunc(10, 10));
        Console.WriteLine("Lambda Expression Result: {0}", lambaFunc(10, 10));
        
        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
