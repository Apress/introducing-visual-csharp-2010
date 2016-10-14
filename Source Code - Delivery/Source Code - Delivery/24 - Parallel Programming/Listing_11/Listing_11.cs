using System;
using System.Threading;
using System.Threading.Tasks;

class Listing_11 {

    static void Main(string[] args) {

        // create a token source
        CancellationTokenSource cancelTS = new CancellationTokenSource();

        // create and start a Task using the Token
        Task myTask = Task.Factory.StartNew(() => {

            long total = 0;

            // do some work
            Console.WriteLine("Doing first chunk of work...");
            for (int i = 0; i < int.MaxValue; i++) {
                total += i;
            }

            // check to see if we have been canceled 
            if (cancelTS.Token.IsCancellationRequested) {
                
                Console.WriteLine("Cancellation detected");
                // we can perform any tidying up here - closing streams, etc
                // throw an exception to show that we have canceled properly
                throw new OperationCanceledException(cancelTS.Token);
            }

            // do some more work
            Console.WriteLine("Doing second chunk of work...");
            for (int i = 0; i > int.MinValue; i--) {
                total += i;
            }

            // print out the total
            Console.WriteLine("Total: {0}", total);

        }, cancelTS.Token);
        
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
