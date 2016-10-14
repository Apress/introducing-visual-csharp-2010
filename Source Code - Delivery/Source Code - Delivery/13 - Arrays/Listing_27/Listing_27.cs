using System;

class Listing_27 {

    static void Main(string[] args) {

        // define and populate a rectangular array of strings
        string[,] namesArray = {
            {"apples", "oranges", "grapes", "pears"},
            {"green", "orange", "red", "green"}
        };

        // get a value from the arra
        string val = namesArray[1, 3];

        Console.WriteLine("Value: {0}", val);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}