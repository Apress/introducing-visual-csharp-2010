using System;
using System.Threading.Tasks;

class Listing_09 {

    static void Main(string[] args) {

        // create a datasource 
        string[] fruits = new string[] { "apple", "plum", "cherry", "grape", "banana", "pear", "mango" ,
            "persimmon", "lemon", "lime", "coconut", "pineapple", "orange"};

        // create a parallel loop to process each item
        Parallel.ForEach<string>(fruits, (dataItem, loopstate) => {
            if (dataItem[0] == 'b' /* || loopstate.ShouldExitCurrentIteration */) {
                Console.WriteLine("Found match: {0}", dataItem);
                loopstate.Stop();
            } else {
                Console.WriteLine("{0} has {1} characters", dataItem, dataItem.Length);
            }
        });

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}