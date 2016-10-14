using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

class Listing_06 {

    static void Main(string[] args) {

        // create a new TcpListener object
        TcpListener myListener = new TcpListener(IPAddress.Any, 12000);

        // start accepting connections
        myListener.Start();

        // define a bool that will determine if we keep accepting connections
        bool acceptConnections = true;

        while (acceptConnections) {

            // wait for a connection
            Console.WriteLine("Waiting for connection");
            TcpClient theClient = myListener.AcceptTcpClient();
            Console.WriteLine("Connection accepted");

            // get the Stream object
            Stream netStream = theClient.GetStream();

            // handle the connection - use the result to 
            // determine if we continue to accept connections
            acceptConnections = HandleClientStream(netStream);

            // close the stream
            netStream.Close();
            // close the network connection
            theClient.Close();
        }

        // stop listening on the port
        myListener.Stop();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    private static bool HandleClientStream(Stream clientStream) {
        // ...
        // implement code to handle client here
        // ...
        // return true if you want to accept further connections, false otherwise
        return false;

    }
}
