using System;
using System.IO;

class Listing_17 {

    static void Main(string[] args) {

        // create an empty MemoryStream
        MemoryStream myStream = new MemoryStream();

        // write a series of bytes to the stream
        for (int i = 0; i < 5; i++) {
            myStream.WriteByte((byte)i);
        }

        // reposition the cursor to the start of the stream
        myStream.Seek(0, SeekOrigin.Begin);

        // read back the byte values
        for (int value; (value = myStream.ReadByte()) > -1; ) {
            Console.WriteLine("Read value: {0}", value);
        }

        // get the data in the stream as an array
        byte[] dataArray = myStream.ToArray();

        // create a new memory stream using the dataArray 
        MemoryStream myOtherStream = new MemoryStream(dataArray);

        // write out the capacity of the stream
        Console.WriteLine("Capacity: {0}", myOtherStream.Capacity);
        
        // read the data back from the stream
        // read back the byte values
        for (int i = 0; i < 5; i++) {
            Console.WriteLine("Read value from second stream: {0}", myOtherStream.ReadByte());
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}