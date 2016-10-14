using System;
using System.Collections.Generic;

namespace Listing_01 {
    class Listing_01 {
        static void Main(string[] args) {

            // create a new collection
            ICollection<string> coll = new List<string>();

            // add some items
            coll.Add("apple");
            coll.Add("orange");

            // check to see if a value is in the collection
            Console.WriteLine("Contains 'apple': {0}", coll.Contains("apple"));
            Console.WriteLine("Contains 'cherry': {0}", coll.Contains("cherry"));

            // copy to an array 
            string[] arr = new string[coll.Count];
            coll.CopyTo(arr, 0);

            // enumerate the collection contents
            foreach (string str in coll) {
                Console.WriteLine("Collection item: {0}", str);
            }

            // print out the collection count 
            Console.WriteLine("Count: {0}", coll.Count);

            // clear the contents of the collection
            coll.Clear();

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
