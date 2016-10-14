using System;
using System.Collections.Generic;

namespace Listing_18 {
    class Listing_18 {

        static void Main(string[] args) {

            // create and populate the collection            
            LinkedList<string> list = new LinkedList<string>(
                new string[] {
                    "mango", "cherry", "apricot", "banana",  
                });

            // find a value in the list
            LinkedListNode<string> node = list.Find("cherry");

            // print out the details of the node we found
            Console.WriteLine("Node Value: {0}", node.Value);
            Console.WriteLine("Node Next: {0}", node.Next.Value);
            Console.WriteLine("Node Previous: {0}", node.Previous.Value);

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
