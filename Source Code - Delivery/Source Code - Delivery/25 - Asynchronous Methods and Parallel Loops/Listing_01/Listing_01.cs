using System;
using System.Net;

class Listing_01 {

    static void Main(string[] args) {

        string[] hostNames = new string[] { "www.microsoft.com", "www.apple.com", "www.google.com", "www.ibm.com" };

        for (int i = 0; i < hostNames.Length; i++) {
            // perform a DNS lookup using a name from the array
            IPHostEntry myHostEntry = Dns.GetHostEntry(hostNames[i]);
            // print out the hostname component of the host entry
            Console.WriteLine("Result for {0} is {1}", hostNames[i], myHostEntry.HostName);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}