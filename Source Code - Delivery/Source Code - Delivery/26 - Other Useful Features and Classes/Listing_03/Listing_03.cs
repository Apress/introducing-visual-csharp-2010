using System;
using System.Collections.Generic;
using ResultCache = System.Collections.Generic.Dictionary<System.Tuple<int, int>, System.Tuple<int, int>>;
using ResultTuple = System.Tuple<int, int>;

class Calculator {
    public Tuple<int, int> PerformCalculation(int firstValue, int secondValue) {
        // calculator the sum
        int sum = firstValue + secondValue;
        // calculate the product
        int product = firstValue * secondValue;
        // create and return a tuple<T, T> to contain the result
        return Tuple.Create(sum, product);
    }
}

class Listing_03 {

    static void Main(string[] args) {

        // create the calculator object
        Calculator calc = new Calculator();

        // create the cache using the aliased generic type
        ResultCache myCache = new ResultCache();

        // add some entries to the cache
        myCache.Add(Tuple.Create(10, 20), calc.PerformCalculation(10, 20));
        myCache.Add(Tuple.Create(20, 30), calc.PerformCalculation(20, 30));
        myCache.Add(Tuple.Create(30, 40), calc.PerformCalculation(30, 40));

        // print out the contents of the cache
        foreach (ResultTuple key in myCache.Keys) {
            // get the entry associated with the key
            ResultTuple result = myCache[key];
            // print out the details
            Console.WriteLine("First value: {0}, Second value: {1}, Sum: {2}, Product: {3}",
                key.Item1, key.Item2, result.Item1, result.Item2);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}