using System;

class Listing_08 {

    static void Main(string[] args) {

        // create a TimeSpan value
        TimeSpan myDuration = new TimeSpan(14, 3, 2, 0);

        string customRep = myDuration.ToString("ddd' days, 'hh' hours and 'mm' minutes'");

        // write the custom representaion to the console 
        Console.WriteLine("Custom format: {0}", customRep);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}