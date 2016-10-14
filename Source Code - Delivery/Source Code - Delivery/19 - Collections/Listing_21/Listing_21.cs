using System;
using System.Collections.Generic;

namespace Listing_21 {
    class Listing_21 {

        static void Main(string[] args) {

            // create the IDictionary instance
            IDictionary<string, string> dict = new Dictionary<string, string>();

            // add some data to the dictionary
            dict.Add("apple", "red");
            dict.Add("cherry", "red");
            dict.Add("banana", "yellow");

            // use the indexer
            dict["apple"] = "green";

            // enumerate the contents of the dictionary
            Console.WriteLine("Enumerating dictionary items");
            foreach (KeyValuePair<string, string> kvp in dict) {
                Console.WriteLine("Dictionary Item. Key: {0}, Value: {1}", 
                    kvp.Key, kvp.Value);
            }

            // enumerate just the keys
            Console.WriteLine("\nEnumerating dictionary keys");
            foreach (string key in dict.Keys) {
                Console.WriteLine("Dictionary Key: {0}", key);
            }

            // enumerate just the values
            Console.WriteLine("\nEnumerating dictionary values");
            foreach (string value in dict.Values) {
                Console.WriteLine("Dictionary Value: {0}", value);
            }

            // check to see if a key exists
            bool keyexists = dict.ContainsKey("cherry");
            Console.WriteLine("\nIDictionary contains key 'cherry': {0}", keyexists);

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
