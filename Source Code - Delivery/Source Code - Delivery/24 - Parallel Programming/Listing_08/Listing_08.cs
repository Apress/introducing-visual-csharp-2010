using System;
using System.Threading.Tasks;

class Listing_08 {

    static void Main(string[] args) {

        // create the Task<T> using a lambda expression
        Task<long> myTask = Task<long>.Factory.StartNew(() => {
            long total = 0;
            for (int i = 0; i < int.MaxValue; i++) {
                total += i;
            }
            return total;
        });

        // get the result from the Task
        long result = myTask.Result;

        // print out the result
        Console.WriteLine("Result: {0}", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
