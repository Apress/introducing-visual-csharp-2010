using System;
using System.Collections.Generic;

class Listing_24 {

    static void Main(string[] args) {

        // define and populate an array
        string[] names = { "oranges", "apples", "guava", "peaches", "bananas", "grapes" };

        // implicitly cast the array to an IList<T>
        IList<string> ilist = names;

        // access the array through the IList<T> members
        int index = ilist.IndexOf("apples");

        // print out the result
        Console.WriteLine("Index: {0}", index);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}