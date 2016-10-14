using System;
using System.Threading.Tasks;

class Listing_22 {

    static void Main(string[] args) {

        // create the first task
        Task<int> firstTask = new Task<int>(() => {
            Console.WriteLine("First Task Started");
            // do some simple work and return the result
            return 10 + 20;
        });

        // create the second task
        Task<int> secondTask = firstTask.ContinueWith<int>((Task<int> antecedent) => {
            Console.WriteLine("Second Task Started");
            // do some simple work and combine with the antecdent result
            return 30 + antecedent.Result;
        });

        // create the third task
        Task<int> thirdTask = secondTask.ContinueWith<int>((Task<int> antecedent) => {
            Console.WriteLine("Third Task Started");
            // do some simple work and combine with the antecedent result
            return 40 + antecedent.Result;
        });

        // create the fourth task
        Task finalTask = thirdTask.ContinueWith((Task<int> antecedent) => {
            Console.WriteLine("Final Task Started");
            // do some simple work and combine with the antecedent result
            int finalResult = antecedent.Result * 10;
            Console.WriteLine("Final Task Finished");
        });

        // start the first Task 
        firstTask.Start();

        // wait for the final Task to complete
        finalTask.Wait();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}