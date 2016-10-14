using System;
using System.Collections.Generic;

namespace Listing_16 {
    class Listing_16 {

        static void Main(string[] args) {

            // create and populate the collection            
            LinkedList<string> list = new LinkedList<string>(
                new string[] {
                    "mango", "cherry", "apricot", "banana",  
                });
            
            // add new first and last items
            LinkedListNode<string> newfirst = list.AddFirst("apple");
            LinkedListNode<string> newlast = list.AddLast("guava");

            // print out the contents of the list
            EnumerateList("Added new first and last items", list);

            // insert items using the LinkedListNodes we got
            // back when we added new first and last items
            list.AddAfter(newfirst, "papaya");
            list.AddBefore(newlast, "peach");

            // print out the contents of the list
            EnumerateList("Inserted new items", list);

            // remove the first and last items
            list.RemoveFirst();
            list.RemoveLast();

            // print out the contents of the list
            EnumerateList("Removed first and last items", list);
            
            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }

        static void EnumerateList(string message, LinkedList<string> list) {
            Console.WriteLine(message);
            foreach (string s in list) {
                Console.WriteLine("List Item: {0}", s);
            }
            Console.WriteLine();
        }
    }
}
