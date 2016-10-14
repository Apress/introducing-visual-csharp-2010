using System;

delegate int PerformCalc(int x, int y);

class Calculator {
    public enum Modes {
        Normal,
        Iterative
    };

    public PerformCalc GetDelegate(Modes mode) {
        if (mode == Modes.Normal) {
            return CalculateNormally;
        } else {
            return CalculateIteratively;
        }
    }

    private int CalculateNormally(int x, int y) {
        return x * y;
    }

    private int CalculateIteratively(int x, int y) {
        int result = 0;
        for (int i = 0; i < x; i++) {
            result += y;
        }
        return result;
    }
}

class Listing_06 {

    static void Main(string[] args) {

        // create a new Calculator
        Calculator calc = new Calculator();

        // get a delegate
        PerformCalc del = calc.GetDelegate(Calculator.Modes.Normal);
        // use the delegate
        Console.WriteLine("Normal product: {0}", del(10, 20));

        // get a delegate
        del = calc.GetDelegate(Calculator.Modes.Iterative);
        // use the delegate
        Console.WriteLine("Iterative product: {0}", del(10, 20));

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}