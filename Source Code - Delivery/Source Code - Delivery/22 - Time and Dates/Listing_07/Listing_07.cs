using System;

class Listing_07 {

    static void Main(string[] args) {

        // create a TimeSpan value
        TimeSpan myDuration = new TimeSpan(14, 23, 12, 20);

        string customRep = myDuration.ToString("d' days, 'h' hours and 'm' minutes'");

        // write the custom representaion to the console 
        Console.WriteLine("Custom format: {0}", customRep);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}