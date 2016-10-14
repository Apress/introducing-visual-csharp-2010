using System;
using System.IO;
using System.Security.Cryptography;

class Listing_03 {

    static void Main(string[] args) {

        // create a new SymmeticAlgoritm object
        SymmetricAlgorithm myAlgorithm = new AesManaged();

        // read and print out the key and IV values
        Console.WriteLine("Key: {0}", Convert.ToBase64String(myAlgorithm.Key));
        Console.WriteLine("IV: {0}", Convert.ToBase64String(myAlgorithm.IV));

        // create a memory stream
        MemoryStream memStream = new MemoryStream();

        // create a CryptoStream that uses the MemoryStream
        CryptoStream myCryptoStream = new CryptoStream(memStream, myAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);

        // create a StreamWriter so we can work with strings and not bytes
        StreamWriter myStreamWriter = new StreamWriter(myCryptoStream);

        // write some secret data
        myStreamWriter.Write("The gold is hidden in the kitchen");

        // close the encrypted data from the memory stream
        myStreamWriter.Close();

        byte[] encryptedData = memStream.ToArray();

        // encode and print out the data
        Console.WriteLine("Data: {0}", Convert.ToBase64String(encryptedData));
       
        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}