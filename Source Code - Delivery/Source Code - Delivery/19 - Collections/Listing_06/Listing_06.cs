using System;
using System.Collections.Generic;

namespace Listing_06 {
    class Listing_06 {

        static void Main(string[] args) {

            // create the list collection
            List<string> list = new List<string>() {
                "apple", "apricot", "banana", "cherry", 
                 "mango", "orange", "pear"};

            // create a predicate so we can resuse the 
            // same instance in multiple method calls
            Predicate<string> p = new Predicate<string>(s => s[0] == 'a');

            // find the first matches with the predicate
            string item1 = list.Find(p);
            int index1 = list.FindIndex(p);

            // find the last matches with the predicate
            string item2 = list.FindLast(p);
            int index2 = list.FindLastIndex(p);

            // print out the results
            Console.WriteLine("Find: {0}, FindIndex: {1}", item1, index1);
            Console.WriteLine("FindLast: {0}, FindLastIndex: {1}", item2, index2);

            List<string> sublist = list.FindAll(p);
            // enumerate the sub-list
            foreach (string str in sublist) {
                Console.WriteLine("Sublist Item: {0}", str);
            }

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
