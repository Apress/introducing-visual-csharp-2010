using System;

class Listing_03 {

    static void Main(string[] args) {

        try {

            MethodOne();

        } catch (NullReferenceException ex) {
            Console.WriteLine("Exception: {0}", ex.Message);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    static void MethodOne() {
        Console.WriteLine("Start of MethodOne");
        MethodTwo();
        // print out a message - this statement will not
        // be reached because the previous statement calls
        // a method that throws an exception
        Console.WriteLine("End of MethodOne");
    }

    static void MethodTwo() {
        try {
            Console.WriteLine("Start of MethodTwo");
            MethodThree();
            // print out a message - this statement will not
            // be reached because the previous statement calls
            // a method that throws an exception
            Console.WriteLine("End of MethodTwo");

        } catch (ArgumentOutOfRangeException ex) {
            // handle this kind of exception
        }
    }

    static void MethodThree() {
        Console.WriteLine("Start of MethodThree");

        // define a loval variable
        string myLocalVar = null;

        // try to so something with the local variable
        Console.WriteLine("First letter: {0}", myLocalVar[0]);
        // print out a message - this statement will not
        // be reached because the previous statement will
        // throw an exception
        Console.WriteLine("End of MethodThree");
    }
}

