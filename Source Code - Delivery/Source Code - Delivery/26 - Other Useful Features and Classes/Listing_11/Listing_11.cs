using System;
using System.Text;

class Listing_11 {

    static void Main(string[] args) {

        // get the bytes from the string
        byte[] myBytes = Encoding.ASCII.GetBytes("Hello World");

        // get the string from the bytes
        string myString = Encoding.ASCII.GetString(myBytes);

        Console.WriteLine("String value: {0}", myString);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}