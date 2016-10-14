using System;
using System.Diagnostics;

class Listing_02 {

    static void Main(string[] args) {

        string eventSource = "C# Intro Source";

        if (!EventLog.SourceExists(eventSource)) {
            // we need to create the source
            Console.WriteLine("Need to create source {0}", eventSource);
            // create the source
            EventLog.CreateEventSource(eventSource, "Application");
            Console.WriteLine("Created source {0}", eventSource);
        } else {
            Console.WriteLine("Source already exists: {0}", eventSource);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}