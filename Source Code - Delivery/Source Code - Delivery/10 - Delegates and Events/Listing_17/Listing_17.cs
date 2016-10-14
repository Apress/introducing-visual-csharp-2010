using System;

class Calculator {

    public void CalculateProduct() {
        // perform the calculation
        int result = 10 * 20;
        // print out a message with the result
        Console.WriteLine("Result: {0}", result);
    }
}

class Listing_17 {

    static void Main(string[] args) {

        // create a new instance of Calculator
        Calculator calc = new Calculator();

        // crete an action and assign a method
        Action act = calc.CalculateProduct;

        // invoke the method via the Action
        act();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

