using System;
using System.IO;

class Listing_12 {

    static void Main(string[] args) {

        // combine strings to make a path
        string[] strComponents = new string[] { @"C:\", "pagefile.sys" };
        string combinedPath = Path.Combine(strComponents);
        Console.WriteLine("Combined path: {0}", combinedPath);

        // does the path have an extension?
        bool hasExtension = Path.HasExtension(combinedPath);
        Console.WriteLine("Has extension: {0}", hasExtension);

        // change the extension part of the path
        string extensionMod = Path.ChangeExtension(combinedPath, "dat");
        Console.WriteLine("Modified path: {0}", extensionMod);

        // get the file name (with and without the extension)
        string fileName = Path.GetFileName(combinedPath);
        string fileNameNoExt = Path.GetFileNameWithoutExtension(combinedPath);
        Console.WriteLine("File name: {0}", fileName);
        Console.WriteLine("File name (no extension): {0}", fileNameNoExt);

        // get the user's temp directory
        string tempDir = Path.GetTempPath();
        Console.WriteLine("Temp dir: {0}", tempDir);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
