using System;
using System.Net.NetworkInformation;

class Listing_17 {

    static void Main(string[] args) {

        // register a handler with the connectivity change event
        NetworkChange.NetworkAvailabilityChanged += (sender, e) => {
            Console.WriteLine("Connectivity Changed - network available? {0}", e.IsAvailable);
        };

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}