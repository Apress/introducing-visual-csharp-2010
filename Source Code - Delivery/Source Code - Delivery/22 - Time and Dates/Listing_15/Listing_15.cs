using System;

class Listing_15 {

    static void Main(string[] args) {

        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");

        // create a DateTime value
        DateTime myDateTime = new DateTime(2012, 1, 20, 9, 50, 32);

        string customRep = "'Month: 'MMM', Year: 'yyyy";

        // write the custom representation to the console
        Console.WriteLine("Custom format: {0}", myDateTime.ToString(customRep));
        
        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}