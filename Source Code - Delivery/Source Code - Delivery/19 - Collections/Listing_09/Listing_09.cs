using System;
using System.Collections.Generic;

namespace Listing_09 {
    class Listing_09 {

        static void Main(string[] args) {

            // create the first list collection
            List<string> list1 = new List<string>() {
                "mango", "cherry", "apricot", "banana",  
                "apple", "pear", "orange"};

            // create the second list
            List<string> list2 = new List<string>() {
                "mango", "cherry", "apricot", "banana",  
                "apple", "pear", "orange"};

            // call the Sort() method on the first list
            list1.Sort();
            // explicitly use the default Comparer on the second list
            list2.Sort(Comparer<string>.Default);

            // enumerate the contents of the lists
            foreach (string s in list1) {
                Console.WriteLine("List 1 item: {0}", s);
            }
            foreach (string s in list2) {
                Console.WriteLine("List 2 item: {0}", s);
            }

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
