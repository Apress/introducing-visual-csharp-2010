using System;
using System.Threading.Tasks;

class Listing_19 {

    static void Main(string[] args) {

        Task firstTask = new Task(() => {
            Console.WriteLine("First task starting");
            long result = 0;
            for (int i = 0; i < int.MaxValue; i++) {
                result += i;
            }
            Console.WriteLine("First task result: {0}", result);
            Console.WriteLine("First task complete");
        });

        Task secondTask = firstTask.ContinueWith((Task antecedent) => {
            Console.WriteLine("Second task starting");
            long result = 0;
            for (int i = 0; i > int.MinValue; i--) {
                result += i;
            }
            Console.WriteLine("Second task result: {0}", result);
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
