using System;
using System.Collections.Generic;

namespace Listing_27 {
    class Listing_27 {

        static void Main(string[] args) {

            SortedSet<string> set = new SortedSet<string>() {
                "banana", "apple", "cherry", "strawberry", "mango"
            };

            // enumerate the contents of the sorted set
            Console.WriteLine("Enumerating SortedSet");
            foreach (string s in set) {
                Console.WriteLine("SortedSet Item: {0}", s);
            }

            // get a view of part of the set
            SortedSet<string> view = set.GetViewBetween("banana", "mango");
            // enumerate the view
            Console.WriteLine("\nEnumerating View");
            foreach (string s in view) {
                Console.WriteLine("View Item: {0}", s);
            }


            // remove some items from the set
            set.RemoveWhere(s => s.Length < 6);

            // enumerate the set now we have removed some items
            Console.WriteLine("\nEnumerating SortedSet");
            foreach (string s in set) {
                Console.WriteLine("SortedSet Item: {0}", s);
            }

            // enumerate the view
            Console.WriteLine("\nEnumerating View");
            foreach (string s in view) {
                Console.WriteLine("View Item: {0}", s);
            }

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
