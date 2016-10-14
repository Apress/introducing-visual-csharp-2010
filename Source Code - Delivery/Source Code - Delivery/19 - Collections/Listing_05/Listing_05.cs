using System;
using System.Collections.Generic;

namespace Listing_05 {
    class Listing_05 {

        static void Main(string[] args) {

            // create the list collection
            List<string> list = new List<string>() {
                "apple", "apricot", "banana", "cherry", 
                 "mango", "orange", "pear"};

            // create a predicate that uses the 
            // PredicateExample method
            Predicate<string> p = new Predicate<string>(PredicateExample);

            // use the Exists method with the predicate
            bool result1 = list.Exists(p);
            // use the Exists method with a lambda expression
            bool result2 = list.Exists(s => s.Length == 6 && s[0] == 'b');
            // write out the results
            Console.WriteLine("Result1: {0}, Result2: {1}", result1, result2);

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }

        static bool PredicateExample(string str) {
            return str.Length == 6 && str[0] == 'b';
        }
    }
}
