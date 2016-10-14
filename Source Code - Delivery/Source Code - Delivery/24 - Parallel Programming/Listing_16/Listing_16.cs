using System;
using System.Threading.Tasks;

class Listing_16 {

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

        } catch (AggregateException aggEx) {
            // enumerate the exceptions
            foreach (Exception innerEx in aggEx.InnerExceptions) {
                Console.WriteLine("Inner exception: {0} - {1}", innerEx.GetType(), innerEx.Message);
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