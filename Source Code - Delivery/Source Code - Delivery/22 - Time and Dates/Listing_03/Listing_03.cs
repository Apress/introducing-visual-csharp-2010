using System;

class Listing_03 {

    static void Main(string[] args) {

        // create a TimeSpan value
        TimeSpan myDuration = new TimeSpan(24, 30, 0);

        // print out the value of some of the TotalXXX properties
        Console.WriteLine("Total days: {0}", myDuration.TotalDays);
        Console.WriteLine("Total hours: {0}", myDuration.TotalHours);
        Console.WriteLine("Total minutes: {0}", myDuration.TotalMinutes);
        Console.WriteLine("Total seconds: {0}", myDuration.TotalSeconds);

        // print out the value of some of the other properties
        Console.WriteLine("Days: {0}", myDuration.Days);
        Console.WriteLine("Hours: {0}", myDuration.Hours);
        Console.WriteLine("Mins: {0}", myDuration.Minutes);
        Console.WriteLine("Seconds: {0}", myDuration.Seconds);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

