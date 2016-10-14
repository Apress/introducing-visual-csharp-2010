using System;

class Listing_13 {

    static void Main(string[] args) {

        // use the multiplication operator
        float mresult = 2.4f * 32.4f;
        Console.WriteLine("Multiplication result: {0}", mresult);

        // use the division operator
        int dresult = 3 / 2;
        Console.WriteLine("Division result: {0}", dresult);

        // use the remainder operator
        float rresult = 6.5f % 3;
        Console.WriteLine("Remainder result: {0}", rresult);

        // use the addition operator
        long x = 34;
        long aresult = 245 + x;
        Console.WriteLine("Addition result: {0}", aresult);

        // use the subtraction result
        float f1 = 2.5f;
        float f2 = 65.7f;
        float sresult = f1 - f2;
        Console.WriteLine("Subtraction result: {0}", sresult);
        
        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}