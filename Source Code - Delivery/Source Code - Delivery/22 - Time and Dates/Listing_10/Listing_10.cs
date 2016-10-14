using System;

class Listing_10 {

    static void Main(string[] args) {

        //System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");

        // use the Now property
        DateTime nowValue = DateTime.Now;
        // print out the value
        Console.WriteLine("Now: {0}", nowValue);

        // use the Today property
        DateTime todayValue = DateTime.Today;
        // print out the value
        Console.WriteLine("Today: {0}", todayValue);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
