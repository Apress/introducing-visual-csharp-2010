using System;
using System.Net;

class Listing_05 {

    static void Main(string[] args) {

        // create a new WebClient objecty
        WebClient myWebClient = new WebClient();

        // subscribe to an event
        myWebClient.DownloadStringCompleted += (sender, eventArgs) => {
            // write out the first part of the string
            Console.WriteLine("--- Async Result ---");
            Console.WriteLine(eventArgs.Result.Substring(0, 50));
        };

        // make an asynchronous request
        myWebClient.DownloadStringAsync(new Uri("http://www.microsoft.com"));

        // do some other work while the request is being performed in the background
        for (int i = 0; i < 10; i++) {
            Console.WriteLine("Doing other work...{0}", i);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
