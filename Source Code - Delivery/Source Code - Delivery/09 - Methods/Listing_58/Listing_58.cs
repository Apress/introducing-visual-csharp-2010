using System;
using System.Collections.Generic;

class Counter {
    private int[] arrDataOdd  = { 1, 3, 5 };
    private int[] arrDataEven = { 2, 4, 6 };

    public IEnumerator<int> GetEnumerator() {
        for (int i = 0; i < arrDataEven.Length; i++) {
            yield return arrDataOdd[i];
            yield return arrDataEven[i];
            yield return arrDataEven[i] + arrDataOdd[i];
        }
        yield return 100;
        yield return 500;
    }
}

class Listing_58 {

    static void Main(string[] args) {

// create a new instance of Counter
Counter count = new Counter();

// use the Counter instance in a foreach loop
foreach (int i in count) {
    Console.WriteLine("Value: {0}", i);
}

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}