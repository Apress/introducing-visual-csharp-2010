using System;
using System.Numerics;

class Listing_23 {

    static void Main(string[] args) {

        // create a new BigInteger using a numeric literal
        BigInteger bigInt = long.MaxValue;
        // create a new BigInteger with a value that cannot be 
        // expressed using a numeric literal
        BigInteger bigInt2 = BigInteger.Parse("92233720368547758070");

        // add the two big integers together using the += operator
        bigInt += bigInt2;
        Console.WriteLine("Result after adding two BigInteger values: {0}", bigInt);

        // subtract using a numeric literal
        bigInt = bigInt2 - 500;
        Console.WriteLine("Result after subtacting a literal: {0}", bigInt);

        // multiply using a numeric type
        int i = 300;
        bigInt *= i;
        Console.WriteLine("Result after multiplung with an int: {0}", bigInt);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}