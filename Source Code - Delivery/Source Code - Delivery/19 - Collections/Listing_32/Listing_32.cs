using System;
using System.Collections.Generic;

namespace Listing_32 {
    class Listing_32 {

        static void Main(string[] args) {

            // create an array
            string[] strArray = new string[] { "apple", "orange", "banana", "cherry", "guava" };

            // use the implicit interface implementations
            // to populate a List<T>
            List<string> list = new List<string>(strArray);

            // filter the items in the array
            string[] filterArray = Array.FindAll(strArray, s => s.Length == 6);
            // enumerate the filter results
            Console.WriteLine("Enumerating filter results");
            foreach (string s in filterArray) {
                Console.WriteLine("Filtered item: {0}", s);
            }

            // sort the array
            Array.Sort(strArray);

            // enumerate the (sorted) array
            Console.WriteLine("\nEnumerating sorted array");
            foreach (string s in strArray) {
                Console.WriteLine("Array item: {0}", s);
            }

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
