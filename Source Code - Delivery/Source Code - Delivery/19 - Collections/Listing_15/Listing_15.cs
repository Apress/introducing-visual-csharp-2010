using System;
using System.Collections.Generic;

namespace Listing_15 {
    class Listing_15 {

        static void Main(string[] args) {

            // create the collection
            List<string> list = new List<string>(100) {
                "mango", "cherry", "apricot", "banana",  
                "apple", "pear", "orange"};

            // create the array
            string[] array = new string[list.Count];

            // copy the contents of the list to the array
            list.CopyTo(array);

            // enumerate the contents of the array
            foreach (string s in array) {
                Console.WriteLine("Array Item: {0}", s);
            }

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
