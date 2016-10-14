using System;
using System.Collections.Generic;

namespace Listing_31 {
    class Listing_31 {

        static void Main(string[] args) {

            // create the Dictionary
            Dictionary<string, string> dict = new Dictionary<string, string>
                (new StringLengthEqualityComparer()) {
                    {"apple", "green"},
                    {"banana", "yellow"},
            };

            bool containsKey = dict.ContainsKey("mango");
            Console.WriteLine("Dictionary contains key 'mango': {0}", 
                containsKey);

            // enumerate the keys
            foreach (string key in dict.Keys) {
                Console.WriteLine("Key: {0}", key);
            }

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }

    class StringLengthEqualityComparer : IEqualityComparer<string> {

        public bool Equals(string x, string y) {
            return x.Length == y.Length;
        }

        public int GetHashCode(string x) {
            return x.Length;
        }
    }
}
