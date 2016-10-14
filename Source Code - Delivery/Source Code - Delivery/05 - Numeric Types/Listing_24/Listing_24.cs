using System;

class Listing_24 {

    static void Main(string[] args) {

        // assign values to a bool variable
        bool var1 = true;
        bool var2 = false;

        Console.WriteLine("Value 1: {0}", var1);
        Console.WriteLine("Value 2: {0}", var2);

        // use a bool literal in a conditional statement
        if (true) {
            Console.WriteLine("Hello");
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}