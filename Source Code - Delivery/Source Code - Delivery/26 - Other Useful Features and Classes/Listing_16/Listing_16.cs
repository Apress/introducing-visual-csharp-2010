using System;
using System.Net.NetworkInformation;

class Listing_16 {

    static void Main(string[] args) {

        // check the overall connectivity
        bool isNetworkAvailable = NetworkInterface.GetIsNetworkAvailable();

        // enumerate the status of individual interfaces
        NetworkInterface[] myInterfaces = NetworkInterface.GetAllNetworkInterfaces();
        foreach (NetworkInterface networkInterface in myInterfaces) {
            if (networkInterface.OperationalStatus == OperationalStatus.Up) {
                Console.WriteLine("Name: {0}, Type: {1}, Avalable: {2}",
                    networkInterface.Name,
                    networkInterface.NetworkInterfaceType,
                    networkInterface.OperationalStatus);
            }
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
