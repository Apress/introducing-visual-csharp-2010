using System;
using System.Threading.Tasks;

class Listing_17 {

    static void Main(string[] args) {

        // create a collection to contain the Tasks
        Task<long>[] tasksArray = new Task<long>[4];

        // create the tasks
        for (int i = 0; i < tasksArray.Length; i++) {
            tasksArray[i] = Task<long>.Factory.StartNew((stateObject) => {
                int taskID = (int)stateObject;
                long total = 0;
                for (int j = 0; j < int.MaxValue; j++) {
                    total = CalculateSum(taskID, j, total);
                }
                return total;
            }, i);
        }

        try {

            // wait for all of the tasks to complete
            Task.WaitAll(tasksArray);

        } catch (AggregateException) {
            // work through the set of Tasks and use the properties 
            // to determine what happened
            for (int i = 0; i < tasksArray.Length; i++) {
                // get the exception at the current index
                Task<long> currentTask = tasksArray[i];
                if (currentTask.IsFaulted) {
                    Console.WriteLine("Task {0} encountered an exception", i);
                    // enumerate the exceptions for this Task
                    foreach (Exception innerException in currentTask.Exception.InnerExceptions) {
                        Console.WriteLine("Exception type for Task {0}: {1}", i, innerException.GetType());
                        Console.WriteLine("Exception message for Task {0}: {1}", i, innerException.Message);
                    }
                } else {
                    Console.WriteLine("Task {0} ran to completion", i);
                    Console.WriteLine("Result for Task {0}: {1}", i, currentTask.Result);
                }
            }
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    public static long CalculateSum(int taskID, int x, long y) {
        if (taskID % 2 == 0 && x == 1000) {
            throw new ArgumentOutOfRangeException(string.Format("Exception for taskID {0}", taskID));
        } else {
            return x + y;
        }
    }
}