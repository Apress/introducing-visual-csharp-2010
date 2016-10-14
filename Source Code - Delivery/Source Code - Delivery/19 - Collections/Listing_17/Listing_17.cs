using System;
using System.Collections.Generic;

namespace Listing_17 {
    class Listing_17 {

        static void Main(string[] args) {

            // create and populate the collection            
            LinkedList<string> list = new LinkedList<string>(
                new string[] {
                    "mango", "cherry", "apricot", "banana",  
                });

            LinkedListNode<string> currentNode = list.First;

            do {
                Console.WriteLine("List Item: {0}", currentNode.Value);
                currentNode = currentNode.Next;
            } while (currentNode.Next != null);


            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
