using System;
using System.IO;

class Listing_22 {

    static void Main(string[] args) {

        // create a temporary file name
        string path = Path.GetRandomFileName();

        // create a StreamWriter
        StreamWriter myWriter = new StreamWriter(path);

        // write some values to the stream
        myWriter.WriteLine("Hello, World");
        myWriter.WriteLine(true);
        myWriter.WriteLine(20172);
        myWriter.WriteLine(12.345D);

        // flush and close the writer
        myWriter.Flush();
        myWriter.Close();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();

        // delete the temp file
        File.Delete(path);
    }
}
