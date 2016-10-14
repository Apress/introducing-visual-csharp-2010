using System;
using System.Threading.Tasks;

class Listing_07 {

    static void Main(string[] args) {

        // create a datasource 
        string[] fruits = new string[] {"apple", "plum", "cherry", "grape", "banana", "pear", "mango"};

        // create a parallel foreach to process each item
        Parallel.ForEach<string>(fruits, dataItem => {
            Console.WriteLine("{0} has {1} characters", dataItem, dataItem.Length);
        });

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}