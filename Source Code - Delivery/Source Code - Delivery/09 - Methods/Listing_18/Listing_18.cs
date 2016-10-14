using System;

class Calculator {

    public int PerformCalculation(int x, int y = 10, int divisor = 2) {
        return (x * y) / divisor;
    }
}

class Listing_18 {

    static void Main(string[] args) {

        // create a new instance of Calculator
        Calculator calc = new Calculator();

        // call the method overload with three arguments
        int result1 = calc.PerformCalculation(5, 10, 2);
        // call the method overlad with two arguments
        int result2 = calc.PerformCalculation(5, 10);
        // call the method overload with one argument
        int result3 = calc.PerformCalculation(5);

        // print out the results
        Console.WriteLine("First result: {0}", result1);
        Console.WriteLine("Second result: {0}", result2);
        Console.WriteLine("Third result: {0}", result3);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}