using System;
using System.Collections.Generic;

class Counter {

    public IEnumerator<int> GetEnumerator() {
        int resultCount = 0;
        int result = 0;
        while (true) {
            if (resultCount < 5) {
                resultCount++;
                yield return result++;
            } else {
                yield break;
            }
        }
    }
}

class Listing_56 {

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