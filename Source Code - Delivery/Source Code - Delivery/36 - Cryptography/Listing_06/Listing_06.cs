using System;
using System.Security.Cryptography;
using System.Text;

class Listing_06 {

    static void Main(string[] args) {

        // create the algorithm object
        HashAlgorithm myHashAlgorithm = new SHA256Managed();

        // create the data we want to hash
        string myData = "This is my message";

        // compute the hash code for the data
        byte[] hashCode = myHashAlgorithm.ComputeHash(Encoding.Default.GetBytes(myData));

        // print out the hash code
        Console.WriteLine("Hash code: {0}", Convert.ToBase64String(hashCode));

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}