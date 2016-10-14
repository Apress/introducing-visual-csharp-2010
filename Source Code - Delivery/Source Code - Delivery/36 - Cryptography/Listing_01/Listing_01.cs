using System;
using System.Security.Cryptography;
using System.Text;

class Listing_01 {

    static void Main(string[] args) {

        SymmetricAlgorithm myAlgorithm = new AesManaged();

        // print out the key
        Console.WriteLine("Key: {0}", Convert.ToBase64String(myAlgorithm.Key));
        
        // print out the IV
        Console.WriteLine("IV: {0}", Convert.ToBase64String(myAlgorithm.IV));

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
