using System;
using System.Collections.Generic;

class Counter {

    public IEnumerator<int> GetEnumerator() {   
        for (int i = 0; i < 5; i++) {
            yield return i;
        }
    }
}

class Listing_55 {

    static void Main(string[] args) {

        // create a new instance of the Counter class
        Counter count = new Counter();

        // use the counter instance as the source for a foreach loop
        foreach (int i in count) {
            Console.WriteLine("Value: {0}", i);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}