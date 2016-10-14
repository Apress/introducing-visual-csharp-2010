using System;
using System.Collections.Generic;

namespace Listing_30 {
    class Listing_30 {

        static void Main(string[] args) {

            // create and populate the collection
            SortedSet<string> set = new SortedSet<string>(new StringLengthComparer()) {
                "banana", "mango", "cherry", "apple", "guava"
            };

            // enumerate the contents of the set
            foreach (string s in set) {
                Console.WriteLine("Set Item: {0}", s);
            }

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }

        class StringLengthComparer : IComparer<string> {
            public int Compare(string T1, string T2) {
                return Comparer<int>.Default.Compare(T1.Length, T2.Length);
            }
        }

        class NoDefaultStringComparer : IComparer<string> {

            public int Compare(string T1, string T2) {
                if (T1.Length == T2.Length) {
                    return 0;
                } else if (T1.Length > T2.Length) {
                    return 1;
                } else {
                    return -1;
                }
            }
        }
    }
}
