using System;
using System.Collections.Generic;
using System.Linq;

class Listing_10 {

    static void Main(string[] args) {

        List<string> myFruitList = new List<string>() {
            "apple", "plum", "cherry", "grape", "banana", "pear", "mango" , 
            "persimmon", "lemon", "lime", "coconut", "pineapple", "orange"};

        IEnumerable<int> results = from e in myFruitList
                                      where e[0] == 'p'
                                      select e.Length;

        foreach (int i in results) {
            Console.WriteLine("Result item: {0}", i);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}