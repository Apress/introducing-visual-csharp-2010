using System;
using System.Collections.Generic;

namespace Listing_11 {
    class Listing_11 {

        static void Main(string[] args) {

            // create the first list collection
            List<string> list = new List<string>() {
                "mango", "cherry", "apricot", "banana",  
                "apple", "pear", "orange"};

            // create the comparer
            StringLengthComparer slc = new StringLengthComparer();

            // sort the list
            list.Sort(slc);

            // perform the binary searches
            int index1 = list.BinarySearch("cherry", slc);
            int index2 = list.BinarySearch("cherry");

            // write out the results
            Console.WriteLine("Result 1: {0}", index1);
            Console.WriteLine("Result 2: {0}", index2);

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
