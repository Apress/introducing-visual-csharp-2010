﻿using System;

class Listing_20 {

    static void Main(string[] args) {

        // define and populate an array
        string[] names = { "oranges", "apples", "guava", "peaches", "bananas", "grapes" };

        // print out the details of the array
        printArrayDetails(names);

        // resize the array
        Array.Resize(ref names, 8);

        // print out the details of the array
        Console.WriteLine("\nFinished resizing array");
        printArrayDetails(names);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    static void printArrayDetails(string[] arr) {
        // report the size of the array
        Console.WriteLine("Array Length: {0}", arr.Length);

        // report on the contents of the array
        foreach (string s in arr) {
            if (s == null) {
                Console.WriteLine("Item: null");
            } else {
                Console.WriteLine("Item: {0}", s);
            }
        }
    }
}