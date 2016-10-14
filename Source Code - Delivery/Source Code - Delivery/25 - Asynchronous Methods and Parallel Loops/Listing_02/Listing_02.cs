using System;
using System.Net;

class Listing_02 {

    static void Main(string[] args) {

        string[] hostNames = new string[] { "www.microsoft.com", "www.apple.com", "www.google.com", "www.ibm.com" };

        for (int i = 0; i < hostNames.Length; i++) {
            Dns.BeginGetHostEntry(hostNames[i], GetHostEntryCallback, hostNames[i]);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    static void GetHostEntryCallback(IAsyncResult result) {
        // get the result of the async method call
        IPHostEntry hostEntry = Dns.EndGetHostEntry(result);

        // print out the host name
        Console.WriteLine("Result for {0} is {1}", result.AsyncState, hostEntry.HostName);
    }
}