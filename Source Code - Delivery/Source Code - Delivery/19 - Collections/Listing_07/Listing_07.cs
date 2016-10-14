using System;
using System.Collections.Generic;

namespace Listing_07 {
    class Listing_07 {

        static void Main(string[] args) {

            // create the list collection
            List<string> list = new List<string>() {
                "apple", "apricot", "banana", "cherry", 
                 "mango", "orange", "apricot", "pear"};

            // find an item using IndexOf and LastIndexOf
            int index1 = list.IndexOf("apricot");
            int index2 = list.LastIndexOf("apricot");

            // write the results
            Console.WriteLine("IndexOf: {0}", index1);
            Console.WriteLine("LastIndexOf: {0}", index2);

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
