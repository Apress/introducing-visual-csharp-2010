using System;
using System.Collections.Generic;
using System.Linq;

class Listing_09 {

    static void Main(string[] args) {

        List<string> myFruitList = new List<string>() {
            "apple", "plum", "cherry", "grape", "banana", "pear", "mango" , 
            "persimmon", "lemon", "lime", "coconut", "pineapple", "orange"};

        IEnumerable<string> results = from e in myFruitList
                                      where e[0] == 'p' && e[1] == 'e' && e.Length > 4
                                      select e;

        foreach (string str in results) {
            Console.WriteLine("Result item: {0}", str);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}