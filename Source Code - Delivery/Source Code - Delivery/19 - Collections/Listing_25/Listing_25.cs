using System;
using System.Collections.Generic;

namespace Listing_25 {
    class Listing_25 {

        static void Main(string[] args) {

            // create the ISet<T>
            ISet<string> set = new HashSet<string>() {
                "apple", "banana", "cherry"
            };

            // create the other collection
            IEnumerable<string> otherCollection = new string[] { "banana", "strawberry", "pear", "cherry", "apple" };
            
            // use the proper superset and subset methods
            bool result1 = set.IsProperSubsetOf(otherCollection);
            bool result2 = set.IsProperSupersetOf(otherCollection);
            // write out the results
            Console.WriteLine("IsProperSubset: {0}, IsProperSuperset: {1}", result1, result2);

            // use the regular superset and subset methods
            bool result3 = set.IsSubsetOf(otherCollection);
            bool result4 = set.IsSupersetOf(otherCollection);
            // write out the results
            Console.WriteLine("IsSubset: {0}, IsSuperset: {1}", result3, result4);

            // use the overlaps methods
            bool result5 = set.Overlaps(otherCollection);
            Console.WriteLine("Overlaps: {0}", result5);

            // get the interset
            set.IntersectWith(otherCollection);

            // enumerate the (intersected) set
            foreach (string s in set) {
                Console.WriteLine("Set Item: {0}", s);
            }

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
