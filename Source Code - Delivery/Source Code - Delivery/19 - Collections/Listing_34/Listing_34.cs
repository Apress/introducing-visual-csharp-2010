using System;
using System.Collections.Generic;

namespace Listing_34 {
    class Listing_34 {

        static void Main(string[] args) {

            // create a normal List<T> and populate it
            List<string> normalList = new List<string>() { "apple", "orange", "banana" };

            // create a readonly list from the normal list
            IList<string> readonlyList = normalList.AsReadOnly();

            // use this statement if you don't want changes in normalList to 
            // affect the contents of the read-only list
            //IList<string> readonlyList =  new List<string>(normalList).AsReadOnly();

            // report on Read-Only state of each list
            Console.WriteLine("normalList is read-only: {0}", ((IList<string>)normalList).IsReadOnly);
            Console.WriteLine("readonlyList is read-only: {0}", readonlyList.IsReadOnly);

            // try to modify the read-only collection
            Console.WriteLine("\nTrying to remove an item from the read-only list");
            try {
                readonlyList.Add("guava");
            } catch (Exception ex) {
                Console.WriteLine("Exception: {0}", ex.GetType());
            }

            // remove an item from the normal List<T>
            normalList.Remove("orange");

            // enumerate the contents of the read-only list
            Console.WriteLine("\nEnumerating readonly list");
            foreach (string s in readonlyList) {
                Console.WriteLine("Readonly List Item: {0}", s);
            }

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
