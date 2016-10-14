using System;
using System.Net;

class Listing_17 {

    static void Main(string[] args) {

        // perform a DNS lookup on www.microsoft.com
        IPHostEntry myEntry = Dns.GetHostEntry("www.microsoft.com");

        // print out the host name
        Console.WriteLine("Hostname: {0}", myEntry.HostName);

        // enumerate the addresses for this host
        foreach (IPAddress addr in myEntry.AddressList) {
            Console.WriteLine("Address: {0}", addr);
        }

        if (myEntry.Aliases.Length > 0) {
            // enumerate the strings for this host
            foreach (string str in myEntry.Aliases) {
                Console.WriteLine("Alias: {0}", str);
            }
        } else {
            Console.WriteLine("There are no aliases");
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
