using System;
using System.IO;

class Listing_04 {

    static void Main(string[] args) {

        string[] fileNames = Directory.GetFiles(@"C:\");

        // print out information for each file
        foreach (string name in fileNames) {
            Console.WriteLine("---");
            Console.WriteLine("File name: {0}", name);
            Console.WriteLine("Created: {0}", Directory.GetCreationTime(name));
            Console.WriteLine("Accessed: {0}", Directory.GetLastAccessTime(name));
            Console.WriteLine("Modified: {0}", Directory.GetLastWriteTime(name));
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

