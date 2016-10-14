using System;

class Calculator {

    public int PerformCalculation(int x, int y) {
        if (x > 10 || y > 10) {
            throw new ArgumentOutOfRangeException();
        } else {
            return x * 10;
        }
    }

    public bool TryPerformCalculation(int x, int y, out int result) {
        try {
            result = PerformCalculation(x, y);
            return true;
        } catch (ArgumentOutOfRangeException) {
            result = -1;
            return false;
        } 
    }
}

class Listing_14 {

    static void Main(string[] args) {

        // create a new instance of Calculator
        Calculator calc = new Calculator();

        // use the perform calc method directly
        int result = calc.PerformCalculation(5, 5);
        Console.WriteLine("Direct result: {0}", result);

        // use the tryXXX method
        int result2;
        bool success = calc.TryPerformCalculation(5, 5, out result2);
        Console.WriteLine("TryXXX first result: {0}, {1}", success, result2);

        success = calc.TryPerformCalculation(20, 5, out result2);
        Console.WriteLine("TryXXX second result: {0}, {1}", success, result2);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}