using System;
using System.Threading.Tasks;

class Listing_25 {

    static void Main(string[] args) {

        // define a shared counter 
        int counter = 0;

        // create an object to use in the critical region
        object myLock = new object();

        // create an array of Tasks
        Task[] taskArray = new Task[10];

        // create and start a series of Tasks that will share the counter
        for (int i = 0; i < taskArray.Length; i++) {
            taskArray[i] = Task.Factory.StartNew(() => {
                // enter a loop and increment the counter
                for (int j = 0; j < 1000; j++) {
                    lock (myLock) {
                        // increment the shared counter
                        counter++;
                    }
                }
            });
        }

        // wait for all of the Tasks to complete
        Task.WaitAll(taskArray);

        // print out the value of the shared counter
        Console.WriteLine("Counter value: {0}", counter);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
