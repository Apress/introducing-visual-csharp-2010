using System;

class Listing_18 {

    static void Main(string[] args) {

        // define the values that will be used with the operators
        int x = 25;
        int y = 50;

        // use the == operator
        bool r1 = x == y;
        Console.WriteLine("== result: {0}", r1);

        // use the != operator
        bool r2 = x != y;
        Console.WriteLine("!= result: {0}", r2);

        // use the < operator
        bool r3 = x < y;
        Console.WriteLine("< result: {0}", r2);

        // use the > operator
        bool r4 = x > y;
        Console.WriteLine("> result: {0}", r4);

        // use the <= operator
        bool r5 = x <= y;
        Console.WriteLine("<= result: {0}", r5);

        // use the >= operator
        bool r6 = x >= y;
        Console.WriteLine(">= result: {0}", r6);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}