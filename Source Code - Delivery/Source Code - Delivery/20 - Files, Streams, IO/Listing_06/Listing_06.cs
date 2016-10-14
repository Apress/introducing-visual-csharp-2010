using System;
using System.IO;

class Listing_06 {

    static void Main(string[] args) {

        // set the working directory for the program
        Directory.SetCurrentDirectory(@"C:\");

        // create a FileInfo object using a drive letter
        FileInfo fqInfo = new FileInfo(@"C:\pagefile.sys");

        // create a FileInfo object with a path starting with a backslash
        FileInfo pqInfo = new FileInfo(@"\pagefile.sys");

        // create a FileInfo object with a relative path
        FileInfo relativeInfo = new FileInfo("pagefile.sys");

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}