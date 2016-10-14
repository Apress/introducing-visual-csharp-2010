using System;
using System.Collections.Generic;

namespace Listing_03 {
    class Listing_03 {
        static void Main(string[] args) {

            // create two lists, specifying the initial elements
            List<string> list1 = new List<string>() { "apple", "orange"};
            List<string> list2 = new List<string>() { "cherry", "mango"};

            // use the add range method to add the
            // contents of one list to the other
            list1.AddRange(list2);

            // enumerate the contents of the list
            writeList("Combined List", list1);
            
            // use the GetRange method
            List<string> rangelist = list1.GetRange(1, 2);
            writeList("GetRange List", rangelist);

            // use the InsertRange method
            list1.InsertRange(1, rangelist);
            writeList("Insert Range List", list1);

            // use RemoveRange
            list1.RemoveRange(0, 3);
            writeList("RemoveRange", list1);
            
            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }

        private static void writeList(string msg, List<string> list) {
            Console.WriteLine(msg);
            foreach (string str in list) {
                Console.WriteLine("List item: {0}", str);
            }
        }
    }
}
