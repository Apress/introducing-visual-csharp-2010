using System;

public delegate int PerformCalc(int x, int y);

class Calculator {
    PerformCalc perfCalc;

    public Calculator() {
        perfCalc = CalculateProduct;
    }

    public PerformCalc CalcDelegate {
        get { return perfCalc; }
    }

    private int CalculateProduct(int num1, int num2) {
        return num1 * num2;
    }
}

class Listing_03 {

    static void Main(string[] args) {

        Calculator calc = new Calculator();

        // get the delegate
        PerformCalc del = calc.CalcDelegate;

        // invoke the delegate to get a result
        int result = del(10, 20);

        // print out the result
        Console.WriteLine("Result: {0}", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}