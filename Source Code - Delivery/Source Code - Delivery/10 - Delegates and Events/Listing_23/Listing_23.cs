using System;

class Calculator {
    Func<int, int, int> calcFunction;

    public Calculator(Func<int, int, int> function) {
        calcFunction = function;
    }

    public int PerformCalculation(int x, int y) {
        return calcFunction(x, y);
    }
}

class Listing_23 {

    static void Main(string[] args) {
        
        // define a local variable
        int calculationCount = 0;

        // define and implement a Func
        Func<int, int, int> productFunc = delegate(int x, int y) {
            // increment the outer variables
            calculationCount++;
            // calculate and return the result
            return x * y;
        };

        // create a new instance of Calculator
        Calculator calc = new Calculator(productFunc);

        // perform several calculations
        for (int i = 0; i < 5; i++) {
            Console.WriteLine("Result {0} = {1}", i, calc.PerformCalculation(i, i));
        }

        // print out the value of the outer variable
        Console.WriteLine("calculationCount: {0}", calculationCount);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}