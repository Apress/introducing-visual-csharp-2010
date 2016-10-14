using System;
using System.Security.Cryptography;

class Listing_09 {

    static void Main(string[] args) {

        // create a new number generator
        RandomNumberGenerator rng = RandomNumberGenerator.Create();

        // define a byte array to fill with random data
        byte[] randomData = new byte[10];

        // generate random data
        rng.GetBytes(randomData);

        // print out the data
        Console.WriteLine(BitConverter.ToString(randomData));

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
