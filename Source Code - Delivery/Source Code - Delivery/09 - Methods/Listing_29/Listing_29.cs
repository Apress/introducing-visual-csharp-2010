using System;

class Calculator {

    public int PerformCalculation(int x, int y) {
        return x + y;
    }

    public long PerformCalculation(long x, long y) {
        return x * y;
    }
}

class Listing_29 {

    static void Main(string[] args) {

        // create a new instance of Calculator
        Calculator calc = new Calculator();

        // call the PerformCalculation method
        long res = calc.PerformCalculation(10, 10);
        // print the results
        Console.WriteLine("Result: {0}", res);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}