using System;
using System.Threading.Tasks;

class Listing_08 {

    static void Main(string[] args) {

        // create a datasource 
        string[] fruits = new string[] { "apple", "plum", "cherry", "grape", "banana", "pear", "mango" };

        // create a paralell for loop to process each item
        Parallel.For(0, fruits.Length, dataIndex => {
            Console.WriteLine("{0} has {1} characters", fruits[dataIndex], fruits[dataIndex].Length);
        });

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}