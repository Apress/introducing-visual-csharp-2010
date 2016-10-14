using System;
using System.Collections.Generic;

namespace Listing_13 {
    class Listing_13 {

        static void Main(string[] args) {

            // create the collection
            List<string> list = new List<string>(100) {
                "mango", "cherry", "apricot", "banana",  
                "apple", "pear", "orange"};

            // write out the element count and the capacity
            Console.WriteLine("Count: {0}, Capacity: {1}", list.Count, list.Capacity);

            // trim the excess capacity
            list.TrimExcess();

            // write out the element count and the capacity again
            Console.WriteLine("Count: {0}, Capacity: {1}", list.Count, list.Capacity);

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
