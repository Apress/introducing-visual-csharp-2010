using System;
using System.Threading.Tasks;

class Listing_10 {

    static void Main(string[] args) {

        // create (but don't start) a Task<long>
        Task<long> myTask = new Task<long>(() => {
            long total = 0;
            for (int i = 0; i < int.MaxValue; i++) {
                total += i;
            }
            return total;
        });

        // print the Task status
        Console.WriteLine("Task status: {0}", myTask.Status);

        // start the Task
        myTask.Start();

        // print the Task status
        Console.WriteLine("Task status: {0}", myTask.Status);

        // wait for the Task to complete
        myTask.Wait();

        // print the Task status
        Console.WriteLine("Task status: {0}", myTask.Status);

        // print out the result from the Task
        Console.WriteLine("Result: {0}", myTask.Result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
