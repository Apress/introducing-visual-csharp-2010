using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Listing_02 {

    static void Main(string[] args) {

        // create and start a new StopWatch
        Stopwatch timer = Stopwatch.StartNew();

        // add up all the positive values that int can represent
        Task<long> positiveTask = Task<long>.Factory.StartNew(() => {
            long posTotal = 0;

            for (int i = 0; i < int.MaxValue; i++) {
                posTotal += i;
            }
            return posTotal;
        });

        // add up all the negative values that int can represent
        Task<long> negativeTask = Task<long>.Factory.StartNew(() => {
            long negTotal = 0;
            for (int i = 0; i > int.MinValue; i--) {
                negTotal += i;
            }
            return negTotal;
        });

        // add the result values together
        long combinedTotal = positiveTask.Result + negativeTask.Result;

        // stop the timer
        timer.Stop();

        // print out the total time
        Console.WriteLine("Elapsed time: {0}", timer.Elapsed);
        Console.WriteLine("Positive total {0}", positiveTask.Result);
        Console.WriteLine("Negative total {0}", negativeTask.Result);
        Console.WriteLine("Combined total {0}", combinedTotal);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}