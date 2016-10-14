using System;
using System.Collections;

namespace Listing_36 {
    class Listing_36 {

        static void Main(string[] args) {

            // create the legacy list
            ArrayList list = new ArrayList() { "apple", 3, "banana", "cherry" };

            // enumerate the contents of the list
            foreach (object o in list) {
                string s = o as string;
                if (s != null) {
                    Console.WriteLine("List item - string: {0}", s);
                } else {
                    Console.WriteLine("List item - {0}: {1}",
                        o.GetType().Name, o.ToString());
                }
            }

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
