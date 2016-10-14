using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;

class Listing_02 {

    static void Main(string[] args) {

        // create a WebClient object
        WebClient myWebClient = new WebClient();

        // use the BaseAddress property
        myWebClient.BaseAddress = "http://www.microsoft.com";

        // get the headers collection
        NameValueCollection headersCollection = myWebClient.Headers;
        // add a header to the collection
        headersCollection.Add("MyHeader", "MyHeaderValue");

        // get the data for the US english home page
        Console.WriteLine("--- First result ---");
        Stream dataStream = myWebClient.OpenRead("en/us/default.aspx");
        Console.WriteLine(ReadFirstString(dataStream));

        // reuse the same web request to get the UK englsh page
        Console.WriteLine("--- Second Result ---");
        dataStream = myWebClient.OpenRead("en/gb/default.aspx");
        Console.WriteLine(ReadFirstString(dataStream));

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    static string ReadFirstString(Stream dataStream) {
        // create a reader around the stream
        StreamReader myReader = new StreamReader(dataStream);
        // read the first line from the stream
        string firstString = myReader.ReadLine().Substring(0, 80);
        // close the reader (and therefore the stream as well)
        myReader.Close();
        // return the string
        return firstString;
    }
}
