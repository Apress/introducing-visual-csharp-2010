using System;
using System.Collections.Generic;

namespace Listing_02 {
    class Listing_02 {
        static void Main(string[] args) {

            // create a new list
            IList<string> list = new List<string>();

            // add new items with the Add method
            list.Add("apple");
            list.Add("orange");
            list.Add("cherry");

            // use the indexer to set the third value
            list[2] = "mango";

            // insert an item at the head of the list
            list.Insert(0, "banana");

            // remove an item
            list.RemoveAt(2);

            // enumerate the items in the list
            foreach (string str in list) {
                Console.WriteLine("List item: {0}", str);
            }

            // check for items in the list
            Console.WriteLine("Index of {0}: {1}", "apple",
                list.IndexOf("apple"));
            Console.WriteLine("Index of {0}: {1}", "apricot",
                list.IndexOf("apricot"));

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
