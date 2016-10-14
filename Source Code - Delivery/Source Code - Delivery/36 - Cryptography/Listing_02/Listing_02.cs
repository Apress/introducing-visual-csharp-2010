using System;
using System.Security.Cryptography;
using System.Text;

class Listing_02 {

    static void Main(string[] args) {

        SymmetricAlgorithm myAlgorithm = new AesManaged();

        // decode the key and IV
        byte[] key = Convert.FromBase64String("Mg4/3QM2Z7fWHWpaFpSl362ERWDLVzt95lxBy0G1qPQ=");
        byte[] iv = Convert.FromBase64String("BvwVkCwsetgeMBls1FWZNg==");

        // set the properties on the algorithm object
        myAlgorithm.Key = key;
        myAlgorithm.IV = iv;

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
