using System;

class Listing_06 {

    static void Main(string[] args) {

        // create a TimeSpan value
        TimeSpan myDuration = new TimeSpan(14, 23, 12, 20);

        // write the value to the console using the standard formatting elements
        Console.WriteLine("Constant format: {0:c}", myDuration);
        Console.WriteLine("General short format: {0:g}", myDuration);
        Console.WriteLine("General long format: {0:G}", myDuration);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
