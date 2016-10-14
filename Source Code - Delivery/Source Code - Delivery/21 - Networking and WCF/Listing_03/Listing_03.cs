using System;
using System.Net;

class Listing_03 {

    static void Main(string[] args) {

        // create a new WebClient object
        WebClient myWebClient = new WebClient();

        // set a base address
        myWebClient.BaseAddress = "http://www.microsoft.com";

        // download a URL to a byte array
        byte[] byteData = myWebClient.DownloadData("en/us/default.aspx");
        // print out the first few byte values
        Console.WriteLine("--- Byte Data ---");
        for (int i = 0; i < 20 && i < byteData.Length; i++) {
            Console.Write("{0},", byteData[i]);
        }
        Console.WriteLine();

        // download the data to a string
        string dataString = myWebClient.DownloadString("en/us/default.aspx");
        // print the first few characters of the string
        Console.WriteLine("--- String Data ---");
        Console.WriteLine(dataString.Substring(0, 80));

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
