using System;
using System.IO;

class Listing_09 {

    static void Main(string[] args) {

        // create the DirectoryInfo object
        DirectoryInfo myDir = new DirectoryInfo(@"C:\");

        // get the FileSystemInfo objects for the directory
        FileSystemInfo[] fsiArray = myDir.GetFileSystemInfos();

        // process each FileSystemInfo
        foreach (FileSystemInfo fsi in fsiArray) {
            string fileOrDir = fsi is FileInfo ? "file" : "directory";
            Console.WriteLine("{0} is a {1}", fsi.Name, fileOrDir);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}