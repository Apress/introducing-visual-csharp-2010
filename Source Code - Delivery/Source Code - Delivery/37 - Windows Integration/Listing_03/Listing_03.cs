using System;
using System.Diagnostics;
using System.Text;

class Listing_03 {

    static void Main(string[] args) {

        // define the event source 
        string eventSource = "C# Intro Source";

        // write an event to the log
        EventLog.WriteEntry(
            eventSource,
            "This is a test event",
            EventLogEntryType.Information,
            1,
            0,
            Encoding.ASCII.GetBytes("Here is some data"));

        Console.WriteLine("Event written to log");

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}