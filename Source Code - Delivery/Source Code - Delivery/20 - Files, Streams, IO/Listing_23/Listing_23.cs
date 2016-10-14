using System;
using System.IO;

class Listing_23 {

    static void Main(string[] args) {

        // create a backing stream
        MemoryStream memStream = new MemoryStream();

        // create a StreamWriter
        StreamWriter myWriter = new StreamWriter(memStream);

        // write some values to the stream
        myWriter.WriteLine("Hello, World");
        myWriter.WriteLine(true);
        myWriter.WriteLine(20172);
        myWriter.WriteLine(12.345D);

        // flush the data
        myWriter.Flush();

        // reposition the cursor in the backing stream
        memStream.Seek(0, SeekOrigin.Begin);

        // create a stream reader
        StreamReader myReader = new StreamReader(memStream);

        // read the strings
        string value;
        while ((value = myReader.ReadLine()) != null) {
            Console.WriteLine("Read Line: {0}", value);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();


    }
}
