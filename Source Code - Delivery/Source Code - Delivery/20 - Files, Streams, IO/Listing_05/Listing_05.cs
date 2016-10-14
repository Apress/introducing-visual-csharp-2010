using System;
using System.IO;

class Listing_05 {

    static void Main(string[] args) {

        // get the current working directory
        string currentDir = Directory.GetCurrentDirectory();
        Console.WriteLine("Current directory: {0}", currentDir);

        // get the files in this directory
        string[] fileNames = Directory.GetFiles(".");
        foreach (string name in fileNames) {
            Console.WriteLine("File: {0}", name);
        }

        // change the working directory
        Directory.SetCurrentDirectory(@"C:\");

        // get the files in this directory
        fileNames = Directory.GetFiles(".");
        Console.WriteLine("--- New Working Directory ---");
        foreach (string name in fileNames) {
            Console.WriteLine("File: {0}", name);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
