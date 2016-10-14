using System;

class Listing_11 {

    static void Main(string[] args) {

        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");

        // use the Now property
        DateTime nowValue = DateTime.Now;
        
        // use the informational properties to print out details
        Console.WriteLine("Day of week: {0}", nowValue.DayOfWeek);
        Console.WriteLine("Day of year: {0}", nowValue.DayOfYear);
        Console.WriteLine("Time of day: {0}", nowValue.TimeOfDay);
        Console.WriteLine("Year: {0}", nowValue.Year);
        Console.WriteLine("Month: {0}", nowValue.Month);
        Console.WriteLine("Day: {0}", nowValue.Day);
        Console.WriteLine("Hour: {0}", nowValue.Hour);
        Console.WriteLine("Minutes: {0}", nowValue.Minute);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
