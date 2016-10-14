using System;
using System.Collections.Generic;

class Counter {

    public IEnumerable<int> SumSequence(int start, int max) {
        for (int i = start; i < max; i++) {
            yield return i;
        }
    }
}

class Listing_59_Test {

    static void Main(string[] args) {

        // create a new instance of Counter
        Counter count = new Counter();

        // use the named iterator block
        foreach (int i in count.SumSequence(5, 10)) {
            Console.WriteLine("Value: {0}", i);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
