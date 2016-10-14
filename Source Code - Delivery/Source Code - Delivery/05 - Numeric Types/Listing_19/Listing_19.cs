using System;

class Listing_19 {

    static void Main(string[] args) {

        // define a byte with a value of 138
        byte b = 138;

        // get the binary representation
        string br = Convert.ToString(b, 2);

        // print out the value and the binary representation
        Console.WriteLine("byte value: {0}, binary {1}", b, br);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}