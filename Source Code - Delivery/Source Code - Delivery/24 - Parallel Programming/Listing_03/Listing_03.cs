using System;
using System.Threading.Tasks;

class Listing_03 {

    static void Main(string[] args) {

        // create the action
        Action myAction = new Action(DoSomeWork);

        // create the Task using the Action
        Task myActionTask = new Task(myAction);

        // create an equivilent Task using a lambda expression
        Task myLambdaTask = new Task(() => {
            long total = 0;
            for (int i = 0; i < int.MaxValue; i++) {
                total += i;
            }
            Console.WriteLine("Total from method: {0}", total);
        });

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
