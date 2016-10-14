using System;

class Listing_31 {

    static void Main(string[] args) {

        string[, ,] namesArray = {
            {
                {"apples", "oranges", "bananas"}
            },
            {
                {"green", "orange", "yellow"}
            },
            {
                {"round", "round", "curved"}
            }
        };

        // get a value from the array
        string val = namesArray[0, 0, 1];

        Console.WriteLine("Value: {0}", val);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}