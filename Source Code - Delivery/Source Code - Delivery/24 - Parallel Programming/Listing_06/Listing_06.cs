using System;
using System.Threading.Tasks;

class Listing_06 {

    static void Main(string[] args) {

        // create the action
        Action myAction = new Action(DoSomeWork);

        // create the Task using the Action
        Task manuallyStartedTask = new Task(myAction);
        // manually start the task
        manuallyStartedTask.Start();

        // create and start a Task in a single step
        Task autoStartTask = Task.Factory.StartNew(myAction);

        // wait for both Tasks to complete
        Task.WaitAll(manuallyStartedTask, autoStartTask);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    public static void DoSomeWork() {
        long total = 0;
        for (int i = 0; i < int.MaxValue; i++) {
            total += i;
        }
        Console.WriteLine("Total from method: {0}", total);
    }
}
