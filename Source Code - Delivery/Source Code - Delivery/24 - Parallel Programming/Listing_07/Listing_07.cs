using System;
using System.Threading.Tasks;

class Listing_07 {

    static void Main(string[] args) {

        // create the Func
        Func<long> myFunc = new Func<long>(DoSomeWork);

        // create and start a Task using the Func
        Task<long> myTask = Task<long>.Factory.StartNew(myFunc);

        // get the result from the Task
        long result = myTask.Result;

        // print out the result
        Console.WriteLine("Result: {0}", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    public static long DoSomeWork() {
        long total = 0;
        for (int i = 0; i < int.MaxValue; i++) {
            total += i;
        }
        return total;
    }
}
