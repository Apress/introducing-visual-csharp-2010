using System;

class Listing_22 {

    static void Main(string[] args) {

        // define the value we will use in this example
        int i = 100;
        // print out the initial value
        Console.WriteLine("--- Arithmetic Assignment Operators ---");
        Console.WriteLine("Initial value: {0}", i);

        // use the += operator
        i += 10;
        Console.WriteLine("Value after +=: {0}", i);

        // use the -= operator
        i -= 10;
        Console.WriteLine("Value after -=: {0}", i);

        // use the *= operator
        i *= 10;
        Console.WriteLine("Value after *=: {0}", i);

        // use the /= operator
        i /= 10;
        Console.WriteLine("Value after /=: {0}", i);

        // use the %= operator
        i %= 30;
        Console.WriteLine("Value after %=: {0}", i);

        // print out the initial binary value
        Console.WriteLine("\n--- Logical Assignment Operators ---");
        Console.WriteLine("Initial value: {0}", ConvertToBinary(i));

        // use the &= operator
        i &= 10;
        Console.WriteLine("Value after &=: {0}", ConvertToBinary(i));

        // use the |= operator
        i |= 128;
        Console.WriteLine("Value after |=: {0}", ConvertToBinary(i));

        // use the ^= operator
        i ^= 128;
        Console.WriteLine("Value after ^=: {0}", ConvertToBinary(i));

        // use the <<= operator
        i <<= 2;
        Console.WriteLine("Value after <<=: {0}", ConvertToBinary(i));

        // use the >>= operator
        i >>= 2;
        Console.WriteLine("Value after >>=: {0}", ConvertToBinary(i));

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    private static string ConvertToBinary(int value) {
        return String.Format("{0:00000000}", int.Parse(Convert.ToString(value, 2)));
    }
}