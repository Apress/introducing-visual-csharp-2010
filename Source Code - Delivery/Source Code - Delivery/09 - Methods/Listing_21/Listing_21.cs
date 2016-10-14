using System;

class Calculator {
    private int divisor = 20;

    public int PerformCalculation(int x, int y) {

        // create a local variable with the same name
        // as used for the class field
        int divisor = 100;

        // perform a calculation and return the result
        return x * y / divisor;
    }
}

class Listing_21 {

    static void Main(string[] args) {

        Calculator calc = new Calculator();
        int result = calc.PerformCalculation(10, 10);
        Console.WriteLine("Result: {0}", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}