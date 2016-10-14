using System;
using System.Collections.Generic;

namespace Listing_20 {
    class Listing_20 {

        static void Main(string[] args) {

            // create a sorted list 
            SortedList<string, string> slist
                = new SortedList<string, string>();

            // add some data to the list
            slist.Add("apple", "green");

            // define the strings that will hold the results
            string result1;
            string result2;

            // call the TryGetValue method
            bool found1 = slist.TryGetValue("apple", out result1);
            bool found2 = slist.TryGetValue("guava", out result2);

            // print out the result
            Console.WriteLine("Result: {0}, Value: {1}", found1, result1);
            Console.WriteLine("Result: {0}, Value: {1}", found2, result2);

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
