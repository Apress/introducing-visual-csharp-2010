using System;
using System.Diagnostics;

class Listing_01 {

    static void Main(string[] args) {

        // create and start a new StopWatch
        Stopwatch timer = Stopwatch.StartNew();

        // add up all the positive values that int can represent
        long posTotal = 0;
        for (int i = 0; i < int.MaxValue; i++) {
            posTotal += i;
        }

        // add up all the negative values that int can represent
        long negTotal = 0;
        for (int i = 0; i > int.MinValue; i--) {
            negTotal += i;
        }

        // add the result values together
        long combinedTotal = posTotal + negTotal;

        // stop the timer
        timer.Stop();

        // print out the total time
        Console.WriteLine("Elapsed time: {0}", timer.Elapsed);
        Console.WriteLine("Positive total {0}", posTotal);
        Console.WriteLine("Negative total {0}", negTotal);
        Console.WriteLine("Combined total {0}", combinedTotal);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}