using System;
using System.Collections.Generic;

namespace Listing_19 {
    class Listing_19 {

        static void Main(string[] args) {

            // create a sorted list 
            SortedList<string, string> slist 
                = new SortedList<string, string>();

            // add some data to the list
            slist.Add("apple",  "green");
            slist.Add("pear",   "green");
            slist.Add("banana", "yellow");
            slist.Add("cherry", "red");

            // get the list of keys
            IList<string> keys = slist.Keys;
            // enumerate the keys
            foreach (string s in keys) {
                Console.WriteLine("Key value: {0}", s);
            }

            // use the indexer
            string value1 = slist["apple"];
            string value2 = slist["cherry"];
            Console.WriteLine("Value for 'apple': {0}", value1);
            Console.WriteLine("Value for 'cherry': {0}", value2);

            // get some indices
            int index1 = slist.IndexOfKey("apple");
            int index2 = slist.IndexOfValue("red");
            Console.WriteLine("Index of key 'apple': {0}", index1);
            Console.WriteLine("Index of value 'red': {0}", index2);

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
