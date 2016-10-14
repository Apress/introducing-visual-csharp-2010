using System;
using System.Collections.Specialized;
using System.Net;

class Listing_04 {

    static void Main(string[] args) {

        // create a new WebClient object
        WebClient myWebClient = new WebClient();

        // download a URL as a string
        string dataString = myWebClient.DownloadString("http://www.microsoft.com");

        // get the headers
        NameValueCollection headers = myWebClient.ResponseHeaders;

        foreach (string key in headers.AllKeys) {
            Console.WriteLine("Header: {0}, Value: {1}", key, headers[key]);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
