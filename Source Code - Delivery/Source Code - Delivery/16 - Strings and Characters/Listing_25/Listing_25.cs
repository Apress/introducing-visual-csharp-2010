using System;

class Listing_25 {

    static void Main(string[] args) {

        // use the C format component
        Console.WriteLine("Currency: {0:C2}", 123.456f);

        // use the D format component
        Console.WriteLine("Decimal: {0:D5}", 123);

        // use the E format component
        Console.WriteLine("Exponential: {0:E5}", 123456);

        // use the F format component
        Console.WriteLine("Fixed-point: {0:F5}", 123.456f);

        // use the P format component
        Console.WriteLine("Percentage: {0:P2}", 0.123f);

        // use the X format component
        Console.WriteLine("Hex: {0:X6}", 123456);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
