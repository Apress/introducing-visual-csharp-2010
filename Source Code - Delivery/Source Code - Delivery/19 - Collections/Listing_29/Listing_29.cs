using System;
using System.Collections.Generic;

namespace Listing_29 {
    class Listing_29 {

        static void Main(string[] args) {

            // create the Stack<T>
            Stack<string> stack = new Stack<string>();

            // push some items
            stack.Push("apple");
            stack.Push("cherry");
            stack.Push("banana");

            // peek at the first item
            string peekItem = stack.Peek();
            Console.WriteLine("Peeked: {0}", peekItem);

            // pop an item
            string poppedItem = stack.Pop();
            Console.WriteLine("Popped: {0}", poppedItem);

            // enumerate the remaining items
            foreach (string s in stack) {
                Console.WriteLine("Stack Item: {0}", s);
            }

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
