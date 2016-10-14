using System;
using System.IO;

class Listing_10 {

    static void Main(string[] args) {

        // create a string variable for the file name
        string fileName = @"C:\pagefile.sys";

        // does the file exist?
        bool fileExists = File.Exists(fileName);
        Console.WriteLine("File exists: {0}", fileExists);

        // get the creation, accessed and modified times
        DateTime createdTime = File.GetCreationTime(fileName);
        DateTime accessedTime = File.GetLastAccessTime(fileName);
        DateTime writeTime = File.GetLastWriteTime(fileName);
        Console.WriteLine("Created: {0}", createdTime);
        Console.WriteLine("Accessed: {0}", accessedTime);
        Console.WriteLine("Modified: {0}", writeTime);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
