using System;
using System.Collections.Generic;

namespace Listing_04 {
    class Listing_04 {

        static void Main(string[] args) {

            List<string> list = new List<string>() {
                "apple", "apricot", "banana", "cherry", 
                 "mango", "orange", "pear"};

            int index1 = list.BinarySearch("orange");
            Console.WriteLine("Index 1: {0}", index1);

            int index2 = list.BinarySearch("papaya");
            Console.WriteLine("Index 2 : {0} {1}", index2, ~index2);

            list.Insert(6, "papaya");

            foreach (string s in list) {
                Console.WriteLine("{0}", s);
            }

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
