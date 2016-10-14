using System;

class Listing_14 {

    static void Main(string[] args) {

        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-GB");

        // create a DateTime value
        DateTime myDateTime = new DateTime(2012, 1, 20, 9, 50, 32);

        // print out the short date format
        Console.WriteLine("Short date format: {0:d}", myDateTime);
        // print out the full format with the long time option
        Console.WriteLine("Full format (long time): {0:F}", myDateTime);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
