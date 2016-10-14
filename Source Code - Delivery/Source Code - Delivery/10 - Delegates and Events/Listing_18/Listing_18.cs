using System;

class Calculator {

    public void CalculateProduct(int x, int y) {
        // perform the calculation
        int result = x * y;
        // print out a message with the result
        Console.WriteLine("Result: {0}", result);
    }
}

class Listing_18 {

    static void Main(string[] args) {

        // create a new instance of Calculator
        Calculator calc = new Calculator();

        // crete an action and assign a method
        Action<int, int> act = calc.CalculateProduct;

        // invoke the method via the Action
        act(10, 20);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

