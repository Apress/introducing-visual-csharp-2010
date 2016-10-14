using System;
using System.Threading.Tasks;

class Listing_09 {

    static void Main(string[] args) {

        // create the array of int values we will pass as parameters to the Tasks
        int[] maxValues = new int[] { int.MaxValue, int.MaxValue / 2, int.MaxValue / 4 };
        // create an array to make tracking the Task objects easier
        Task<long>[] tasks = new Task<long>[maxValues.Length];

        // define the Func we will use for all of the Tasks
        Func<object, long> myFunction = DoSomeWork;

        for (int i = 0; i < maxValues.Length; i++) {
            //tasks[i] = Task<long>.Factory.StartNew(myFunction, maxValues[i]);
            tasks[i] = Task<long>.Factory.StartNew(stateObject => {
                int maxValue = (int)stateObject;
                long total = 0;
                for (int j = 0; j < maxValue; j++) {
                    total += j;
                }
                return total;
            }, maxValues[i]);
        }

        // wait for all the Tasks to complete
        Task.WaitAll(tasks);

        // print out the results from each Task
        foreach (Task<long> t in tasks) {
            Console.WriteLine("Result: {0}", t.Result);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    public static long DoSomeWork(object objectParam) {
        int maxValue = (int)objectParam;
        long total = 0;
        for (int i = 0; i < maxValue; i++) {
            total += i;
        }
        return total;
    }

}
