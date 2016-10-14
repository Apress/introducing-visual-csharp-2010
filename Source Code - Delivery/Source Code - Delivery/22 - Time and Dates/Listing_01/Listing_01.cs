using System;
using System.Diagnostics;

class Listing_01 {

    static void Main(string[] args) {

        // create a new StopWatch object
        Stopwatch myTimer = new Stopwatch();

        // start timing
        myTimer.Start();

        // perform the task we want to measure
        long total = 0;
        for (int i = 0; i < int.MaxValue; i++) {
            total += i;
        }

        // stop the timer
        myTimer.Stop();

        // print out the result
        Console.WriteLine("Result: {0}", total);

        // print out how long the operation took
        long elapsedMs = myTimer.ElapsedMilliseconds;
        Console.WriteLine("Operation took: {0}", elapsedMs);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
