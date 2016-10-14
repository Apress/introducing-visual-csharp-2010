using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

class Listing_08 {

    static void Main(string[] args) {

        // create the TcpClient object
        TcpClient myClient = new TcpClient(IPAddress.Loopback.ToString(), 12000);

        // get the Stream object from the client
        Stream dataStream = myClient.GetStream();

        // call the HandleServerStream method
        HandleServerStream(dataStream);

        // close the stream
        dataStream.Close();
        // close the connection
        myClient.Close();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    public static void HandleServerStream(Stream serverStream) {

        // create a StreamReader and StreamWriter around the Stream
        StreamReader myReader = new StreamReader(serverStream);
        StreamWriter myWriter = new StreamWriter(serverStream);

        int[] firstSet = { 10, 20, 30, 40, 50 };
        int[] secondSet = { 3, 6, 9, 3, 4 };

        for (int i = 0; i < 5; i++) {
            // write a message 
            Console.WriteLine("Writing message: {0} {1}", firstSet[i], secondSet[i]);
            myWriter.WriteLine("{0} {1}", firstSet[i], secondSet[i]);
            myWriter.Flush();
            // read a message
            string responseString = myReader.ReadLine();
            Console.WriteLine("Got response: {0}", responseString);
        }
    }
}
