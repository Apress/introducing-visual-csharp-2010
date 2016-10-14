using System;

class Listing_26 {

    static void Main(string[] args) {

        // define a rectangular array of strings
        string[,] namesArray = new string[5, 5];

        // set values in the array
        namesArray[2, 3] = "Oranges";
        namesArray[2, 4] = "Apples";

        // get a value from the arra
        string val = namesArray[2, 4];

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}