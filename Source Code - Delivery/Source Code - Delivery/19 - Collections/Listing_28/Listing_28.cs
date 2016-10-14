using System;
using System.Collections.Generic;

namespace Listing_28 {
    class Listing_28 {

        static void Main(string[] args) {

            // create the Queue<T>
            Queue<string> queue = new Queue<string>();

            // enqueue some items
            queue.Enqueue("apple");
            queue.Enqueue("cherry");
            queue.Enqueue("banana");
            
            // peek at the first item
            string peekItem = queue.Peek();
            Console.WriteLine("Peeked: {0}", peekItem);

            // dequeue an item
            string dequeueItem = queue.Dequeue();
            Console.WriteLine("Dequeued: {0}", dequeueItem);

            // enumerate the remaining items
            foreach (string s in queue) {
                Console.WriteLine("Queue Item: {0}", s);
            }

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
