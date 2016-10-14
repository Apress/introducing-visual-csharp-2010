using System;

class Calculator {

    public virtual int PerformCalculation(int x, int y) {
        return x * y;
    }
}

class Listing_25 {

    static void Main(string[] args) {

        Calculator calc = new Calculator();
        int result = calc.PerformCalculation(10, 10);
        Console.WriteLine("Result: {0}", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}