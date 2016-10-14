using System;
using System.IO;

class Listing_16 {

    static void Main(string[] args) {

        // create the stream object
        Stream myStream = File.Create(Path.GetTempFileName());

        // check the capabilities of the Stream
        Console.WriteLine("CanRead: {0}", myStream.CanRead);
        Console.WriteLine("CanWrite: {0}", myStream.CanWrite);
        Console.WriteLine("CanSeek: {0}", myStream.CanSeek);

        // write a series of bytes to the stream
        for (int i = 0; i < 5; i++) {
            Console.WriteLine("Writing value: {0}", i);
            myStream.WriteByte((byte)i);
        }

        // flush the stream
        myStream.Flush();

        // reposition the cursor to the start of the stream
        myStream.Seek(0, SeekOrigin.Begin);

        // read in a series of bytes
        for (int i = 0; i < 5; i++) {
            Console.WriteLine("Read value: {0}", myStream.ReadByte());
        }

        // reposition the cursor to the start of the stream
        myStream.Seek(0, SeekOrigin.Begin);

        // write a series of bytes to the stream
        for (int i = 10; i < 15; i++) {
            Console.WriteLine("Writing value: {0}", i);
            myStream.WriteByte((byte)i);
        }

        // flush the stream
        myStream.Flush();

        // close the stream
        myStream.Close();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
