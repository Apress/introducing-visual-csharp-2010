using System;
using System.Collections.Generic;

namespace Listing_22 {
    class Listing_22 {

        static void Main(string[] args) {

            // create the ICollection instance
            ICollection<KeyValuePair<string, string>> coll 
                = new Dictionary<string, string>();

            // add some data to the dictionary
            coll.Add(new KeyValuePair<string, string>("apple", "green"));
            coll.Add(new KeyValuePair<string, string>("cherry", "red"));
            coll.Add(new KeyValuePair<string, string>("banana", "yellow"));

            // see if the collection contains specific key value pairs
            bool result1 = coll.Contains(new KeyValuePair<string, string>("apple", "green"));
            bool result2 = coll.Contains(new KeyValuePair<string, string>("apple", "blue"));

            Console.WriteLine("Collection contains apple/green: {0}", result1);
            Console.WriteLine("Collection contains apple/blue: {0}", result2);
            
            // remove an item from the collection
            coll.Remove(new KeyValuePair<string, string>("apple", "green"));

            // enumerate the results
            foreach (KeyValuePair<string, string> kvp in coll) {
                Console.WriteLine("Collection item: {0}/{1}", kvp.Key, kvp.Value);
            }

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
