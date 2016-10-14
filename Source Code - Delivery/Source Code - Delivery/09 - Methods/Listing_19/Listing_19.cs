using System;

class Calculator {

    public int PerformCalculation(int x, int y = 10, int divisor = 2) {
        return (x * y) / divisor;
    }
}

class Listing_19 {

    static void Main(string[] args) {

        // create a new instance of Calculator
        Calculator calc = new Calculator();

        int result = calc.PerformCalculation(y: 10, x: 120, divisor: 5);
        Console.WriteLine("Result: {0}", result);


        result = calc.PerformCalculation(120, divisor: 5);
        Console.WriteLine("Result: {0}", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}