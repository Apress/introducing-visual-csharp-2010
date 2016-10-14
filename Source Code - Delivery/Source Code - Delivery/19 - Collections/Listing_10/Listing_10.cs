using System;
using System.Collections.Generic;

namespace Listing_10 {
    class Listing_10 {

        static void Main(string[] args) {

            // create the first list collection
            List<string> list1 = new List<string>() {
                "mango", "cherry", "apricot", "banana",  
                "apple", "pear", "orange"};

            // sort using a lambda expression
            list1.Sort(new Comparison<string>(
                (s1, s2) =>
                Comparer<int>.Default.Compare(s1.Length, s2.Length)));

            // enumerate the contents of the list
            foreach (string s in list1) {
                Console.WriteLine("List 1 item: {0}", s);
            }

            // create the second list collection
            List<string> list2 = new List<string>() {
                "mango", "cherry", "apricot", "banana",  
                "apple", "pear", "orange"};

            // sort using an implementation of IComparer<T>
            list2.Sort(new StringLengthComparer());

            // enumerate the contents of the list
            foreach (string s in list2) {
                Console.WriteLine("List 2 item: {0}", s);
            }

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }

    class StringLengthComparer : IComparer<string> {
        public int Compare(string x, string y) {
            return Comparer<int>.Default.Compare(x.Length, y.Length);
        }
    }
}
