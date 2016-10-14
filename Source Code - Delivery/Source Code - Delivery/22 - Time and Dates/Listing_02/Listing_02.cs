using System;
using System.Diagnostics;

class Listing_02 {

    static void Main(string[] args) {

        // print out details of the timing resolution and frequency
        Console.WriteLine("Frequency: {0}", Stopwatch.Frequency);
        Console.WriteLine("High Resolution: {0}", Stopwatch.IsHighResolution);

        // get the tick value
        long initialCounterValue = Stopwatch.GetTimestamp();

        // perform the task we want to measure
        long total = 0;
        for (int i = 0; i < int.MaxValue; i++) {
            total += i;
        }

        // get the tick value again
        long finalCounterValue = Stopwatch.GetTimestamp();

        // get the elapsed number of ticks by deducting the 
        // initial value from the final value
        long elapsedCount = finalCounterValue - initialCounterValue;

        // work out how many milliseconds have elapsed by using the 
        // counter frequency
        float milliSecondsElapsed = (elapsedCount / ((float)Stopwatch.Frequency)) * 1000;
        Console.WriteLine("Operation took: {0:F0}ms", milliSecondsElapsed);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}