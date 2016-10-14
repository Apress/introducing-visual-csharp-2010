using System;
using System.Threading;
using System.Threading.Tasks;

class Listing_23 {

    static void Main(string[] args) {

        // create a token source for cancellation
        CancellationTokenSource tokenSource = new CancellationTokenSource();

        // create a Task
        Task<long> firstTask = new Task<long>(() => {
            Console.WriteLine("First task started");
            long result = 0;
            for (int i = 0; i < int.MaxValue; i++) {
                result += i;
                if (tokenSource.Token.IsCancellationRequested) {
                    Console.WriteLine("Task cancelled");
                    tokenSource.Token.ThrowIfCancellationRequested();
                }
            }
            return result;
        }, tokenSource.Token);

        firstTask.ContinueWith((Task<long> antecedent) => {
            Console.WriteLine("Ran to completion continuation - antecedent result is: {0}", antecedent.Result);
        }, TaskContinuationOptions.OnlyOnRanToCompletion);

        firstTask.ContinueWith((Task<long> antecedent) => {
            Console.WriteLine("Canceled continuation");
        }, TaskContinuationOptions.OnlyOnCanceled);

        // start the first task
        firstTask.Start();

        // prompt the user to cancel the token
        Console.WriteLine("Press enter to cancel");
        Console.ReadLine();
        // cancel the token
        tokenSource.Cancel();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}