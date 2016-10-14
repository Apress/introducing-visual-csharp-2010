using System;
using System.Threading.Tasks;

class Listing_15 {

    static void Main(string[] args) {

        Task<long> myTask = Task.Factory.StartNew<long>(() => {
            long total = 0;
            for (int i = 0; i < int.MaxValue; i++) {
                total = CalculateSum(i, total);
            }
            return total;
        });

        try {
            // Get the result from the Task
            long taskResult = myTask.Result;

            // write out the result
            Console.WriteLine("Result: {0}", taskResult);

        } catch (AggregateException aggEx) {
            Console.WriteLine("---- Exception Caught From Trigger Member ---");
            Console.WriteLine("---- Exception type: {0}", aggEx.GetType());
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    public static long CalculateSum(int x, long y) {
        if (x == 1000) {
            throw new ArgumentOutOfRangeException();
        } else {
            return x + y;
        }
    }
}