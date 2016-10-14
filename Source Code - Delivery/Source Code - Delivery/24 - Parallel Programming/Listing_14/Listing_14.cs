using System;
using System.Threading.Tasks;

class Listing_14 {

    static void Main(string[] args) {

        Task<long> myTask = Task.Factory.StartNew<long>(() => {
            long total = 0;
            for (int i = 0; i < int.MaxValue; i++) {
                try {

                    total = CalculateSum(i, total);

                } catch (ArgumentOutOfRangeException ex) {
                    Console.WriteLine("---- Exception Caught In Task Body ---");
                    Console.WriteLine("---- Exception type: {0}", ex.GetType());
                }
            }
            return total;
        });

        // Get the result from the Task
        long taskResult = myTask.Result;
        // write out the result
        Console.WriteLine("Result: {0}", taskResult);
            
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