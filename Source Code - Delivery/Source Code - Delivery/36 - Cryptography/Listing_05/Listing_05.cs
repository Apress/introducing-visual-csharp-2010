using System;
using System.Security.Cryptography;
using System.Text;

class Listing_05 {

    static void Main(string[] args) {

        // define the data to encrypt
        string secretMessage = "The password is 1234";

        // get the bytes from the data
        byte[] secretMessageBytes = Encoding.Default.GetBytes(secretMessage);

        // encrypt the data using DPAPI
        byte[] encryptedData = ProtectedData.Protect(
            secretMessageBytes,
            null, 
            DataProtectionScope.CurrentUser);

        // decrypt the data again
        byte[] decryptedData = ProtectedData.Unprotect(
            encryptedData,
            null,
            DataProtectionScope.CurrentUser);

        // print out the decrypted message
        Console.WriteLine("Decrypted message: {0}", 
            Encoding.Default.GetString(decryptedData));

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
