using System;
using System.IO;
using System.IO.Compression;

class Listing_20 {

    static void Main(string[] args) {

        // create a path for a temporary file with the gzip extension
        string filePath = Path.ChangeExtension(Path.GetRandomFileName(), ".gzip");

        // open a write-only file stream using the file path
        FileStream writeFileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);

        // create the compression stream, backed using the file stream
        GZipStream compressStream = new GZipStream(writeFileStream, CompressionMode.Compress);

        // write some data to the compression stream
        for (int i = 0; i < 5; i++) {
            Console.WriteLine("Writing value: {0}", i);
            compressStream.WriteByte((byte)i);
        }

        // flush and close the stream
        compressStream.Flush();
        compressStream.Close();

        // open the file again, this time as read-only
        FileStream readFileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

        // create a decompression stream, backed by the read-only file stream
        GZipStream decompressStream = new GZipStream(readFileStream, CompressionMode.Decompress);

        // read the compressed data back
        for (int value; (value = decompressStream.ReadByte()) > -1; ) {
            Console.WriteLine("Read value: {0}", value);
        }

        // close the stream
        decompressStream.Close();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
