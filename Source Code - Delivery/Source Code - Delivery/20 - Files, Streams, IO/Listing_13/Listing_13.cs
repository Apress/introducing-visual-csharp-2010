using System;
using System.IO;

class Listing_13 {

    static void Main(string[] args) {

        // create temporary directory
        string tempDirPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());

        // create the directory specified by the path
        Directory.CreateDirectory(tempDirPath);

        // create a FileSystemWatcher to look for changes
        FileSystemWatcher fsWatcher = new FileSystemWatcher(tempDirPath);

        // register handlers with the events of the watcher
        fsWatcher.Changed += new FileSystemEventHandler(HandleFileSystemChangeEvent);
        fsWatcher.Created += new FileSystemEventHandler(HandleFileSystemChangeEvent);
        fsWatcher.Deleted += new FileSystemEventHandler(HandleFileSystemChangeEvent);

        // start watching for events
        fsWatcher.EnableRaisingEvents = true;

        // create a file name that we will use in the temp directory
        string tempFilePath = Path.Combine(tempDirPath, Path.GetRandomFileName());
        Console.WriteLine("Temp file name is: {0}", tempFilePath);

        // create a new file in the temp directory
        File.WriteAllText(tempFilePath, "Hello World");

        // replace the contents of the file
        File.WriteAllText(tempFilePath, "Introduction to C#");

        // delete the file
        File.Delete(tempFilePath);
        
        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    static void HandleFileSystemChangeEvent(object sender, FileSystemEventArgs arg) {
        Console.WriteLine("--- Change Event ---");
        Console.WriteLine("Affected File Name: {0}", arg.Name);
        Console.WriteLine("Change type: {0}", arg.ChangeType);
    }
}
