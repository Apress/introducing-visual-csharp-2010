using System;

class Listing_05 {

    static void Main(string[] args) {

        // create two TimeSpan values
        TimeSpan ts1 = new TimeSpan(4, 0, 0);
        TimeSpan ts2 = new TimeSpan(2, 30, 0);

        // test for equality
        Console.WriteLine("TimeSpan values are equal: {0}", ts1 == ts2);
        Console.WriteLine("TimeSpan values are unequal: {0}", ts1 != ts2);

        // use the addition and subtraction operators
        TimeSpan addResult = ts1 + ts2;
        Console.WriteLine("TimeSpan addition result: {0}", addResult);
        TimeSpan subtractionResult = ts1 - ts2;
        Console.WriteLine("TimeSpan subtraction result: {0}", subtractionResult);

        // compare the values
        Console.WriteLine("TS1 > TS2? {0}", ts1 > ts2);
        Console.WriteLine("TS1 < TS2? {0}", ts1 < ts2);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
