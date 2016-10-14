using System;
using System.IO;

class Listing_21 {

    static void Main(string[] args) {

        // create the backing stream
        MemoryStream backingStream = new MemoryStream();

        // create the BinaryWriter object, backed by the MemoryStream
        BinaryWriter myWriter = new BinaryWriter(backingStream);

        // write a sequence of values to the stream
        myWriter.Write(true);
        myWriter.Write(23.2D);
        myWriter.Write("Hello World");
        myWriter.Write(20172);

        // reset the cursor on the backing stream
        backingStream.Seek(0, SeekOrigin.Begin);

        // create a BinaryReader object, backed by the memory stream
        BinaryReader myReader = new BinaryReader(backingStream);

        // read the data sequence from the reader
        Console.WriteLine("Read bool value: {0}", myReader.ReadBoolean());
        Console.WriteLine("Read float value: {0}", myReader.ReadDouble());
        Console.WriteLine("Read string value: {0}", myReader.ReadString());
        Console.WriteLine("Read int value: {0}", myReader.ReadInt32());

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
