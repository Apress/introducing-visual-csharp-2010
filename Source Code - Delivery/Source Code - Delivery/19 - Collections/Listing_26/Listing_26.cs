using System;
using System.Collections.Generic;

namespace Listing_26 {
    class Listing_26 {

        static void Main(string[] args) {

            // create the two collections we want to work with
            List<string> list1 = new List<string>() { "cherry", "apple", "cherry" };
            List<string> list2 = new List<string>() { "apple", "banana", "orange" };

            // create the HashSet, using one of the collections
            HashSet<string> set = new HashSet<string>(list1);

            // enumerate the set
            Console.WriteLine("Enumerating the HashSet");
            foreach (string s in set) {
                Console.WriteLine("Set Item: {0}", s);
            }

            // modify the set so that it contains only the items
            // which existed in both source collections
            set.UnionWith(list2);

            // create a new list that contains the contents of the set
            List<string> result = new List<string>(set);

            // enumerate the result list
            Console.WriteLine("\nEnumerating the result set");
            foreach (string s in result) {
                Console.WriteLine("Result List Item: {0}", s);
            }

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
