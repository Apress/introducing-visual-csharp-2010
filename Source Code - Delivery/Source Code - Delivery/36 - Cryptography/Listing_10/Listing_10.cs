using System;
using System.Security;
using System.Runtime.InteropServices;

class Listing_10 {

    static void Main(string[] args) {

        // create the SecureString
        SecureString secString = new SecureString();

        // give instruction to the user
        Console.WriteLine("Type password and press enter");

        // define the variable that will hold details of the key press
        ConsoleKeyInfo keyInfo;

        // read from the keyboard
        while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Enter) {
            // append the character to the secure string
            secString.AppendChar(keyInfo.KeyChar);
            // print an asterisk to the user to give feedback
            Console.Write('*');
        }

        // get the unecrypted contents of the secure string
        string unencryptedPassword = Marshal.PtrToStringBSTR(Marshal.SecureStringToBSTR(secString));
        
        // print out the password that the user entered
        Console.WriteLine("\nThe password is: {0}", unencryptedPassword);
        
        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}