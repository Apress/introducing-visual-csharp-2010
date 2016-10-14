using System;
using System.Collections.Generic;
using System.Linq;

class Listing_12 {

    static void Main(string[] args) {

        string[] names = { "oranges", "apples", "guava" };

        IEnumerator<string> e = names.AsEnumerable<string>().GetEnumerator();

        while (e.MoveNext()) {
            string str = e.Current;
            Console.WriteLine("Item: {0}", str);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}