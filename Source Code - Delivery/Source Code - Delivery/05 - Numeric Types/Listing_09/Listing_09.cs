using System;

class Listing_09 {

    static void Main(string[] args) {

        Console.WriteLine("Int Max Value: {0}", int.MaxValue);
        Console.WriteLine("Int Min Value: {0}", int.MinValue);

        Console.WriteLine("ULong Max Value: {0}", ulong.MaxValue);
        Console.WriteLine("ULong Min Value: {0}", ulong.MinValue);

        Console.WriteLine("Float Max Value: {0}", float.MaxValue);
        Console.WriteLine("Float Min Value: {0}", float.MinValue);

        Console.WriteLine("Double Max Value: {0}", double.MaxValue);
        Console.WriteLine("Double Min Value: {0}", double.MinValue);

        Console.WriteLine("Decimal Max Value: {0}", decimal.MaxValue);
        Console.WriteLine("Decimal Min Value: {0}", decimal.MinValue);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}