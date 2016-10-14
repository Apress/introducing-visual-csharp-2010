using System;
using System.Threading.Tasks;

class Listing_20 {

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

        Task secondTask = firstTask.ContinueWith((Task<long> antecedent) => {
            Console.WriteLine("Second task starting");
            // get the result and status from the antecedent task
            Console.WriteLine("Result from antecedent: {0}", antecedent.Result);
            Console.WriteLine("Status from antecedent: {0}", antecedent.Status);
            Console.WriteLine("Second task complete");
        });

        // start the first task
        firstTask.Start();

        // wait for both tasks to complete
        Task.WaitAll(firstTask, secondTask);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}