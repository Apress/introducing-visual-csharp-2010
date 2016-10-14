using System;

class Listing_04 {

    static void Main(string[] args) {

        TimeSpan value1 = TimeSpan.FromDays(1.02083333333333d);
        Console.WriteLine("Timespan 1: {0}", value1);

        TimeSpan value2 = TimeSpan.FromHours(24.5);
        Console.WriteLine("Timespan 2: {0}", value2);

        TimeSpan value3 = TimeSpan.FromMinutes(1470);
        Console.WriteLine("Timespan 3: {0}", value3);

        TimeSpan value4 = TimeSpan.FromSeconds(88200);
        Console.WriteLine("Timespan 3: {0}", value4);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
