using System;
using System.Threading;
using System.Threading.Tasks;

class Listing_13 {

    static void Main(string[] args) {

        // create a token source
        CancellationTokenSource cancelTS = new CancellationTokenSource();

        for (int i = 0; i < 4; i++) {
            // create a Task
            Task.Factory.StartNew(stateObject => {
                Console.WriteLine("Task {0} started", stateObject);
                long total = 0;
                for (int j = 0; j < int.MaxValue; j++) {
                    total += j;
                    if (cancelTS.Token.IsCancellationRequested) {
                        Console.WriteLine("Task {0} canceled", stateObject);
                        throw new OperationCanceledException(cancelTS.Token);
                    }
                }

                Console.WriteLine("Task {0} completed", stateObject);
            }, i, cancelTS.Token);
        }

        // read a line from the Console
        Console.WriteLine("Press enter to cancel token");
        Console.ReadLine();

        // cancel the token
        Console.WriteLine("Token canceled");
        cancelTS.Cancel();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}