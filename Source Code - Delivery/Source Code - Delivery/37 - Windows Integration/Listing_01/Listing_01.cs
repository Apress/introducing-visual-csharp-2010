using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class Listing_01 {

    static void Main(string[] args) {

        // create an EventLog object for the Application log
        EventLog appLog = new EventLog("Application");

        // use the Cast extension method to create a LING-suitable data source
        IEnumerable<EventLogEntry> logEntries = appLog.Entries.Cast<EventLogEntry>();

        // perform a LINQ query on the log entries
        IEnumerable<EventLogEntry> results = from e in logEntries
                                             where e.EntryType == EventLogEntryType.Warning
                                             select e;

        // enumerate the first few events
        foreach (EventLogEntry entry in results.Take(3)) {
            Console.WriteLine("Event Source: {0}", entry.Source);
            Console.WriteLine("Message: {0}", entry.Message);
            Console.WriteLine("---------------");
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
