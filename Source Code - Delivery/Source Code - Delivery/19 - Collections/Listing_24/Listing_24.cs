using System;
using System.Collections.Generic;

namespace Listing_24 {
    class Listing_24 {

        static void Main(string[] args) {

            // create the Dictionary instance
            Dictionary<string, string> dict = new Dictionary<string, string>() { 
                { "apple", "green" },
                { "cherry", "red" },
                { "mango", "green"},
                { "banana", "yellow" },
                { "strawberry", "red" }
            };

            // enumerate the contents of the Dictionary
            Console.WriteLine("Enumerating Dictionary");
            foreach (KeyValuePair<string, string> kvp in dict) {
                Console.WriteLine("Dictionary Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            // create the SortedDictionary
            SortedDictionary<string, string> sdict = new SortedDictionary<string, string>(dict);


            // enumerate the contents of the Dictionary
            Console.WriteLine("\nEnumerating SortedDictionary");
            foreach (KeyValuePair<string, string> kvp in sdict) {
                Console.WriteLine("SortedDictionary Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
