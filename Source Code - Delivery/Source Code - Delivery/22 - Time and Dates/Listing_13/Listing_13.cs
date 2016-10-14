using System;

class Listing_13 {

    static void Main(string[] args) {

        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");

        // create a DateTime value
        DateTime dateTime = new DateTime(2000, 1, 1);
        Console.WriteLine("Initial value: {0}", dateTime);

        // perform some additions
        Console.WriteLine("Add 5 years: {0}", dateTime.AddYears(5));
        Console.WriteLine("Add 5 months: {0}", dateTime.AddMonths(5));
        Console.WriteLine("Add 5 days: {0}", dateTime.AddDays(5));

        // use a double value to change two components
        Console.WriteLine("Add 1.5 hours: {0}", dateTime.AddHours(1.5d));

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}