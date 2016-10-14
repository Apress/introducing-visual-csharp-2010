using System;
using System.Collections.Generic;

namespace Listing_08 {
    class Listing_08 {

        static void Main(string[] args) {

            // create the list collection
            List<string> list = new List<string>() {
                "apple", "apricot", "banana", "cherry", 
                 "mango", "orange", "pear"};

            // reverse the order of the list
            list.Reverse();

            // enumerate the contents of the list
            Console.WriteLine("---Complete Reverse---");
            foreach (string s in list) {
                Console.WriteLine("List item: {0}", s);
            }

            // reverse a part of the list
            list.Reverse(1, 5);

            // enumerate the contents of the list again
            Console.WriteLine("---Range Reverse---");
            foreach (string s in list) {
                Console.WriteLine("List item: {0}", s);
            }

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
