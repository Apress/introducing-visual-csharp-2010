using System;
using System.Collections.Generic;

namespace Listing_14 {
    class Listing_14 {

        static void Main(string[] args) {

            // create the collection
            List<string> list = new List<string>(100) {
                "mango", "cherry", "apricot", "banana",  
                "apple", "pear", "orange"};

            // convert the list
            List<int> convertedList = list.ConvertAll(s => s.Length);

            // enumerate the results
            foreach (int i in convertedList) {
                Console.WriteLine("Converted List Item: {0}", i);
            }

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
