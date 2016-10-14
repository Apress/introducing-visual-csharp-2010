using System;
using System.Threading.Tasks;

class Listing_26 {

    static void Main(string[] args) {

        // define a shared counter 
        int counter = 0;

        // create an object to use in the critical region
        object myLock = new object();

        // create an array of Tasks
        Task<int>[] taskArray = new Task<int>[10];

        // create and start a series of Tasks that will share the counter
        for (int i = 0; i < taskArray.Length; i++) {
            taskArray[i] = Task<int>.Factory.StartNew(() => {

                // create a local counter to work with
                int localCounter = 0;

                // enter a loop and increment the counter
                for (int j = 0; j < 1000; j++) {
                    // increment the shared counter
                    localCounter++;
                }

                // return the local counter
                return localCounter;
            });
        }

        // wait for all of the Tasks to complete
        Task.WaitAll(taskArray);

        // combine the individual results of each Task
        foreach (Task<int> t in taskArray) {
            counter += t.Result;
        }

        // print out the value of the shared counter
        Console.WriteLine("Counter value: {0}", counter);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
