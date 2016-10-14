using System;
using System.Collections.Generic;

class Counter {
    private int[] arrData = {2, 4, 6, 8, 10};

    public IEnumerator<int> GetEnumerator() {
        //foreach (int i in arrData) {
        //    yield return i;
        //}
        return ((IList<int>)arrData).GetEnumerator();
    }
}

class Listing_57 {

    static void Main(string[] args) {

        // create a new instance of Counter
        Counter count = new Counter();

        // enumerate the contents of the counter
        foreach (int i in count) {
            Console.WriteLine("Value: {0}", i);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}