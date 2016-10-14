using System;
using System.IO;
using System.Net;

class Listing_01 {

    static void Main(string[] args) {

        // create a Webclient object
        WebClient myWebClient = new WebClient();

        // open a stream to the target URL
        Stream dataStream = myWebClient.OpenRead("http://microsoft.com");

        // create a StreamReader around the Stream
        StreamReader dataReader = new StreamReader(dataStream);

        // read the contents of the URL as a single string
        string dataLine = dataReader.ReadToEnd();

        // write out the received data
        Console.WriteLine(dataLine);

        // close the reader
        dataReader.Close();
        
        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
