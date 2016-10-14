using System;
using System.IO;

class Listing_01 {

    static void Main(string[] args) {

        string[] filesArray = Directory.GetFiles(@"C:\");
        Console.WriteLine("--- GetFiles Results ---");
        foreach (string name in filesArray) {
            Console.WriteLine("File name: {0}", name);
        }

        string[] dirsArray = Directory.GetDirectories(@"C:\");
        Console.WriteLine("\n--- GetDirectories Results ---");
        foreach (string name in dirsArray) {
            Console.WriteLine("Directory name: {0}", name);
        }

        string[] allArray = Directory.GetFileSystemEntries(@"C:\");
        Console.WriteLine("\n--- GetFileSystemEntries Results ---");
        foreach (string name in allArray) {
            Console.WriteLine("FileSystemEntry name: {0}", name);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}