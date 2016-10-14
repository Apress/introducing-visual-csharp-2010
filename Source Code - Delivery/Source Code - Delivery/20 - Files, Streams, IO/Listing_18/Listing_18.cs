using System;
using System.IO;

class Listing_18 {

    static void Main(string[] args) {

        // create a file stream to an existing file
        FileStream myStream = new FileStream("tempfile.txt", FileMode.Create, FileAccess.ReadWrite);

        // write some data to the file
        for (int i = 0; i < 5; i++) {
            Console.WriteLine("Writing value: {0}", i);
            myStream.WriteByte((byte)i);
        }

        // flush the data, including any intermediate buffers
        myStream.Flush(true);

        // close the file
        myStream.Close();

        // create a new Stream to the same file
        FileStream myOtherStream = new FileStream("tempfile.txt", FileMode.Open, FileAccess.Read);

        // read the data from the stream
        for (int value; (value = myOtherStream.ReadByte()) > -1; ) {
            Console.WriteLine("Read Value: {0}", value);
        }

        // close the file
        myOtherStream.Close();

        // delete the file
        File.Delete("tempfile.txt");

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
