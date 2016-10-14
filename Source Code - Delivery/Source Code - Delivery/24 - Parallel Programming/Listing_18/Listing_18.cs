using System;
using System.Threading.Tasks;

class Listing_18 {

    static void Main(string[] args) {

        TaskScheduler.UnobservedTaskException +=
          (object sender, UnobservedTaskExceptionEventArgs eventArgs) => {

              // mark the exception as being handled
              eventArgs.SetObserved();

              // get the aggregate exception
              AggregateException aggEx = (AggregateException)eventArgs.Exception;

              // enumerate the exceptions
              Console.WriteLine("--- Exceptions handled by custom policy ---");
              foreach (Exception innerEx in aggEx.InnerExceptions) {
                  Console.WriteLine("Inner exception: {0} - {1}",
                      innerEx.GetType(), innerEx.Message);
              }
          };

        // create the tasks
        for (int i = 0; i < 4; i++) {
            Task.Factory.StartNew((stateObject) => {
                int taskID = (int)stateObject;
                long total = 0;
                for (int j = 0; j < int.MaxValue/50; j++) {
                    total = CalculateSum(taskID, j, total);
                }
                Console.WriteLine("Task {0} ran to completion", taskID);
            }, i);
        }

        // prompt the user to press enter to run the GC
        Console.WriteLine("Press enter to run GC");
        Console.ReadLine();
        // run the GC
        GC.Collect();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();        
    }

    public static long CalculateSum(int taskID, int x, long y) {
        if (taskID % 2 == 0 && x == 1000) {
            Console.WriteLine("Throwing an exception for Task {0}", taskID);
            throw new Exception(string.Format("Exception for taskID {0}", taskID));
        } else {
            return x + y;
        }
    }
}
