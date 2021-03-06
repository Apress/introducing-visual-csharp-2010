﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Listing_27 {
    private static object lockObject = new object();
    private static int counter = 0;

    static void Main(string[] args) {

        // create a queue and fill it with data
        Queue<int> myQueue = new Queue<int>();
        for (int i = 0; i < 10000; i++) {
            myQueue.Enqueue(i);
        }

        // create an array to make tracking the Tasks simpler
        Task[] taskArray = new Task[10];
        
        // create and start the Tasks
        for (int i = 0; i < taskArray.Length; i++) {
            taskArray[i] = Task.Factory.StartNew(() => {
                while (myQueue.Count > 0) {
                    // take an item from the queue
                    int item = myQueue.Dequeue();
                    // increment the counter to report that we have taken an item
                    IncrementCounter();
                }
            });
        }

        // wait for all of the Tasks to finish
        Task.WaitAll(taskArray);

        // print out the value of the counter
        Console.WriteLine("Items Processed: {0}", counter);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    private static void IncrementCounter() {
        lock (lockObject) {
            counter++;
        }
    }
}