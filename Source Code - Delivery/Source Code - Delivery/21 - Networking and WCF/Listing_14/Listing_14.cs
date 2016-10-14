using System;
using System.IO;
using System.Net;

class Listing_14 {

    static void Main(string[] args) {

        // define the directory that will be used to load the images
        string baseDir = @"..\..\images\";

        // create a new listener 
        HttpListener myListener = new HttpListener();

        // add the prefixes we will listen for
        myListener.Prefixes.Add("http://+:14000/demo/");

        // start listening for client requests
        myListener.Start();

        while (true) {

            // wait for a client request to arrive
            Console.WriteLine("Waiting for client request");
            HttpListenerContext reqContext = myListener.GetContext();

            // get the request and response objects from the context
            HttpListenerRequest clientRequest = reqContext.Request;
            HttpListenerResponse clientResponse = reqContext.Response;

            // get the file component from the URL
            string filename = clientRequest.Url.LocalPath;
            filename = string.Format("{0}{1}{2}", baseDir, '\\',  filename.Substring(filename.LastIndexOf('/') + 1));

            // see if the file exists
            if (File.Exists(filename)) {
                Console.WriteLine("Request for file: {0}", filename);
                // open a stream to the file and copy the contents to the response stream
                Stream filestream = File.Open(filename, FileMode.Open, FileAccess.Read);
                filestream.CopyTo(clientResponse.OutputStream);
                // close the input stream
                filestream.Close();
            } else {
                // the file does not exist
                Console.WriteLine("Request for nonexistent file: {0}", filename);
                // set an error code for the client
                clientResponse.StatusCode = 404;
            }

            // close the response 
            clientResponse.Close();

        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}