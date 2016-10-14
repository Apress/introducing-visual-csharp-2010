using System;

class Listing_09 {

    static void Main(string[] args) {

        // create a DateTime value
        DateTime myTime = new DateTime(2010, 1, 20, 9, 0, 0, 0);

        // print out the value
        Console.WriteLine("DateTime: {0}", myTime);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}