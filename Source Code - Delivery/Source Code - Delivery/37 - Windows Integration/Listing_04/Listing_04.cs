using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

class Listing_04 {

    static void Main(string[] args) {

        // define the event source 
        string eventSource = "C# Intro Source 2";

        // check the command-line arguments
        if (args.Length > 0 && args[0] == "adminTask") {
            // we have beeb started to perform the admin tasks
            performAdminTasks(eventSource);
            // it is important that we return at this point - we 
            // should not perform any task other than those that 
            // require administration rights
            return;
        } 

        // if we get here, then we are the main program - we have
        // no admin rights
        // - our first task is to create the admin instance of the program
        ProcessStartInfo pstartInfo = new ProcessStartInfo("Listing_04.exe");
        pstartInfo.Arguments = "adminTask";
        pstartInfo.Verb = "runas";
        // start the process and wait for it to complete
        Process.Start(pstartInfo).WaitForExit();


        // we can now be sure that the event source for the event log
        // has been created - write an event to the log
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

    private static void performAdminTasks(string eventSource) {
        // perform the tasks that require admin rights
        if (!EventLog.SourceExists(eventSource)) {
            // we need to create the source
            Console.WriteLine("Need to create source {0}", eventSource);
            // create the source
            EventLog.CreateEventSource(eventSource, "Application");
            Console.WriteLine("Created source {0}", eventSource);
        } else {
            Console.WriteLine("Source already exists: {0}", eventSource);
        }
    }
}
