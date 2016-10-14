using System;
using System.IO;

class Listing_08 {

    static void Main(string[] args) {

        DirectoryInfo myDir = new DirectoryInfo(@"C:\Program Files");

        // does the directory exist
        bool dirExists = myDir.Exists;
        Console.WriteLine("Directory exists? {0}", dirExists);

        // what is the name of the directory
        string dirName = myDir.Name;
        Console.WriteLine("Directory name: {0}", dirName);

        // what is the parent directory name
        string parentName = myDir.Parent.Name;
        Console.WriteLine("Parent name: {0}", parentName);

        // what is the root name
        string rootName = myDir.Root.Name;
        Console.WriteLine("Root name: {0}", rootName);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
