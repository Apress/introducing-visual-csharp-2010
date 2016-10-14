using System;
using System.Collections.Generic;

namespace Listing_12 {
    class Listing_12 {

        static void Main(string[] args) {

            // create the first list collection
            List<string> list = new List<string>() {
                "mango", "cherry", "apricot", "banana",  
                "apple", "pear", "orange"};

            // use the ForEach method
            list.ForEach(s => Console.WriteLine("List Item: {0}", s));

            // use the TrueForAll method
            bool result = list.TrueForAll(s => s.Length > 2);

            Console.WriteLine("Result: {0}", result);

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
