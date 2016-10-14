using System;

class Calculator {

    public int CalculateProduct(int x, int y) {
        // perform the calculation
        return x * y;
    }
}

class Listing_20 {

    static void Main(string[] args) {

        // create a new instance of Calculator
        Calculator calc = new Calculator();

        // create a Func and assign a method
        Func<int, int, int> act = calc.CalculateProduct;

        // invoke the method via the Action
        int result = act(10, 20);

        // print out the result
        Console.WriteLine("Result: {0}", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

