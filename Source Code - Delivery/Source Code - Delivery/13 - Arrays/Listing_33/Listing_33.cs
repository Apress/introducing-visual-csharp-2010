using System;

class Listing_33 {

    static void Main(string[] args) {

        string[][] jaggedArray = new string[3][];

        jaggedArray[0] = new string[2];
        jaggedArray[1] = new string[1];
        jaggedArray[2] = new string[3];

        // set some values in the array
        jaggedArray[0][1] = "oranges";
        jaggedArray[2][2] = "apples";

        // get a value from the array
        string value = jaggedArray[2][2];
        Console.WriteLine("Value: {0}", value);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
