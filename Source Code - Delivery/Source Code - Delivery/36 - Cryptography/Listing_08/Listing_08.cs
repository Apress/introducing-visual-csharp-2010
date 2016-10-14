using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

class Listing_08 {

    static void Main(string[] args) {

        // define the hash code we were sent
        string originalHashCodeString = "jgtZ8C7iFrBr7YRGBqKtN8e8zNTw9Fq791QyOKz2+/E=";
        // decode the hash code to get the bytes
        byte[] originalHashCode = Convert.FromBase64String(originalHashCodeString);

        // open a stream to the file
        Stream myStream = File.OpenRead(@"..\..\datafile.txt");

        // create the hash algorithm object
        HashAlgorithm myHashAlgorithm = new SHA256Managed();

        // generate the new hash code for the data
        byte[] newHashCode = myHashAlgorithm.ComputeHash(myStream);

        // compare the hash codes byte by byte
        bool hashCodeIsValid = newHashCode.SequenceEqual(originalHashCode);

        // print out the hashcode
        Console.WriteLine("Hash code is valid: {0}", hashCodeIsValid);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}