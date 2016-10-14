using System;
using System.IO;

class Listing_07 {

    static void Main(string[] args) {

        FileInfo myFile = new FileInfo(@"C:\pagefile.sys");

        // does the file exist?
        bool fileExists = myFile.Exists;
        Console.WriteLine("File Exists? {0}", fileExists);

        // get the file extension
        string fileExtension = myFile.Extension;
        Console.WriteLine("File Extension: {0}", fileExtension);

        // get the size of the file
        long fileSize = myFile.Length;
        Console.WriteLine("File length: {0} bytes", fileSize);

        // get the name of the directory
        string directoryName = myFile.DirectoryName;
        Console.WriteLine("Directory name: {0}", directoryName);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

