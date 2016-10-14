using System;
using System.IO;
using System.Security.Cryptography;

class Listing_07 {

    static void Main(string[] args) {

        // open a stream to the file
        Stream myStream = File.OpenRead(@"..\..\datafile.txt");

        // create the hash algorithm object
        HashAlgorithm myHashAlgorithm = new SHA256Managed();

        // generate the hash code for the data
        byte[] hashCode = myHashAlgorithm.ComputeHash(myStream);

        // print out the hashcode
        Console.WriteLine("Hash code: {0}", Convert.ToBase64String(hashCode));

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}