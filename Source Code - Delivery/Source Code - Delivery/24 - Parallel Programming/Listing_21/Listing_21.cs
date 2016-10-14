using System;
using System.Threading.Tasks;

class Listing_21 {

    static void Main(string[] args) {

        Task<long> firstTask = new Task<long>(() => {
            Console.WriteLine("First task starting");
            long result = 0;
            for (int i = 0; i < int.MaxValue; i++) {
                result += i;
            }
            Console.WriteLine("First task complete");
            return result;
        });

        Task<int> secondTask = firstTask.ContinueWith<int>((Task<long> antecedent) => {
            Console.WriteLine("Second task starting");
            // get the result and status from the antecedent task
            Console.WriteLine("Result from antecedent: {0}", antecedent.Result);
            Console.WriteLine("Status from antecedent: {0}", antecedent.Status);
            // perform the work
            long result = 0;
            for (int i = 0; i > int.MinValue; i--) {
                result += i;
            }
            Console.WriteLine("Second task complete");
            return (int)(result + antecedent.Result);
        });

        // start the first task
        firstTask.Start();

        // wait for both tasks to complete
        Task.WaitAll(firstTask, secondTask);

        // print out the result from the continuation Task
        Console.WriteLine("Continuation result: {0}", secondTask.Result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
