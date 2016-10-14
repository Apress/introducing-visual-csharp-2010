using System;
using System.Collections.Generic;
using System.Linq;

class Listing_03 {

    static void Main(string[] args) {

        List<string> myFruitList = new List<string>() {
            "apple", "plum", "cherry", "grape", "banana", "pear", "mango" , 
            "persimmon", "lemon", "lime", "coconut", "pineapple", "orange"};

        IEnumerable<string> results = from string e in myFruitList
                                      select e;

        // get the IEnumerator<T> from the IEnumerable<T>
        IEnumerator<string> myEnumerator = results.GetEnumerator();

        while (myEnumerator.MoveNext()) {
            Console.WriteLine("Result item: {0}", myEnumerator.Current);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}