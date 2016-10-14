using System;

class Listing_30 {

    static void Main(string[] args) {

        string[, ,] namesArray = new string[3, 3, 3];

        // set some values in the array
        namesArray[1, 2, 2] = "oranges";
        namesArray[0, 0, 1] = "apples";

        // get a value from the array
        string val = namesArray[0, 0, 1];

        Console.WriteLine("Value: {0}", val);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}