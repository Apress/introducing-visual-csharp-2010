using System;
using System.IO;
using System.Security.Cryptography;

class Listing_04 {

    static void Main(string[] args) {

        // define the key, IV and data
        byte[] myKey = Convert.FromBase64String(
            "i9zrkg4sws97Xly/c4Cw9nPVf85s70A//ZpnWGGV5UM=");
        byte[] myIV = Convert.FromBase64String(
            "TlcaDtlqR+c3mLsDTtePmg==");
        byte[] myEncryptedData = Convert.FromBase64String(
            "FZQuZQNzBC58xNDKjZTXZrS7W8pMPzfmFmR3dzbv3voLI90t0dg/7Wo0VUmtFtIY");

        // create the SymmetricAlgorithm object
        SymmetricAlgorithm myAlgorithm = new AesCryptoServiceProvider();
        // set the key and IV values
        myAlgorithm.Key = myKey;
        myAlgorithm.IV = myIV;

        // create a MemoryStream using the encrypted data
        MemoryStream memStream = new MemoryStream(myEncryptedData);
        memStream.Seek(0, SeekOrigin.Begin);

        // create a CryptoStream that will decrypt the data
        CryptoStream cryptoStream 
            = new CryptoStream(
                memStream, 
                myAlgorithm.CreateDecryptor(), 
                CryptoStreamMode.Read);

        // create a StreamReader so we can work with strings and not bytes
        StreamReader myReader = new StreamReader(cryptoStream);

        // read the secret data
        string mySecret = myReader.ReadToEnd();

        // print out the secret message
        Console.WriteLine("Secret message: {0}", mySecret);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}