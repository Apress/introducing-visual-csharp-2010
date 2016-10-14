﻿using System;
using System.IO;

class Listing_14 {

    static void Main(string[] args) {

        // create temporary directory
        string tempDirPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());

        // create the directory specified by the path
        Directory.CreateDirectory(tempDirPath);

        // create a FileSystemWatcher to look for changes
        FileSystemWatcher fsWatcher = new FileSystemWatcher(tempDirPath);

        // filter the files we are interested in
        fsWatcher.Filter = "*.txt";
        Console.WriteLine("Filter: {0}", fsWatcher.Filter);

        // start watching for events
        fsWatcher.EnableRaisingEvents = true;

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
