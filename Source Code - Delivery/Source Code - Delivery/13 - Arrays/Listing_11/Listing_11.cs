using System;
using System.Collections;

class Listing_11 {

    static void Main(string[] args) {

        string[] names = { "oranges", "apples", "guava" };

        IEnumerator e = names.GetEnumerator();

        while (e.MoveNext()) {
            string str = (string)e.Current;
            Console.WriteLine("Item: {0}", str);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}