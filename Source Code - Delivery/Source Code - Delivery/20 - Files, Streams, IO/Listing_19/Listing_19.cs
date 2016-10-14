using System;
using System.IO;

class Listing_19 {

    static void Main(string[] args) {

        // create the backing stream, which will be itself backed by a file
        FileStream myBaseStream = new FileStream(Path.GetTempFileName(), 
            FileMode.OpenOrCreate, FileAccess.ReadWrite);

        // create the BufferedStream
        BufferedStream myBufferedStream = new BufferedStream(myBaseStream, 10 * 1024);

        // write some data to the buffered stream
        for (int i = 0; i < 5; i++) {
            Console.WriteLine("Writing value: {0}", i);
            myBufferedStream.WriteByte((byte)i);
        }

        // flush so that the buffer is cleared
        myBufferedStream.Flush();

        // reposition the cursor to the start of the buffer
        myBufferedStream.Seek(0, SeekOrigin.Begin);

        // read the data back
        for (int value; (value = myBufferedStream.ReadByte()) > -1;) {
            Console.WriteLine("Read value: {0}", value);
        }

        // close the stream
        myBufferedStream.Close();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}