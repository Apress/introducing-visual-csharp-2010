using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

class Listing_07 {

    static void Main(string[] args) {

        // create a new TcpListener object
        TcpListener myListener = new TcpListener(IPAddress.Any, 12000);

        // start accepting connections
        myListener.Start();

        while (true) {

            // wait for a connection
            Console.WriteLine("Waiting for connection");
            TcpClient theClient = myListener.AcceptTcpClient();
            Console.WriteLine("Connection accepted");

            Task.Factory.StartNew(() => {

                // get the Stream object
                Stream netStream = theClient.GetStream();

                // handle the connection - use the result to 
                // determine if we continue to accept connections
                HandleClientStream(netStream);

                // close the stream
                netStream.Close();
                // close the network connection
                theClient.Close();
            });
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    private static bool HandleClientStream(Stream clientStream) {

        // create StreamReader and StreamWriter objects around the Stream
        StreamReader myReader = new StreamReader(clientStream);
        StreamWriter myWriter = new StreamWriter(clientStream);

        // define a string that will be used to read from the StreamReader
        string dataLine;
        // enter a loop to read lines from the client
        while ((dataLine = myReader.ReadLine()) != null) {
            // read a string from the StreamReader and split it on the space character
            string[] stringElements = dataLine.Split(' ');
            // parse the two integer values
            int firstInt = int.Parse(stringElements[0]), secondInt = int.Parse(stringElements[1]);
            // compute the result
            int result = firstInt + secondInt;
            // print out the information locally
            Console.WriteLine("Task {3}: Server processed request: {0} + {1} = {2}", firstInt, secondInt, result, Task.CurrentId);

            // return the result of the calculation to the cliebt
            myWriter.WriteLine(result);
            // flush the writer to make sure that the data is flushed
            myWriter.Flush();
        }
        // return true if you want to accept further connections, false otherwise
        return false;
    }
}
