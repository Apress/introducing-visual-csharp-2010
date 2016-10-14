using System;

class Calculator {

    public int CalculateProduct() {
        // perform the calculation
        return 10 * 20;
    }
}

class Listing_19 {

    static void Main(string[] args) {

        // create a new instance of Calculator
        Calculator calc = new Calculator();

        // create a Func and assign a method
        Func<int> act = calc.CalculateProduct;

        // invoke the method via the Action
        int result = act();

        // print out the result
        Console.WriteLine("Result: {0}", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

