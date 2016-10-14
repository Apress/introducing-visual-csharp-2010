using System;

abstract class BaseCalculator {

    protected abstract int CalculateProduct(int x, int y);
    protected abstract int CalculateSum(int x, int y);

    public int PerformCalculation(int x, int y, bool calcProduct) {
        if (calcProduct) {
            return CalculateProduct(x, y);
        } else {
            return CalculateSum(x, y);
        }
    }
}

class CalcImpl : BaseCalculator {

    protected override int CalculateProduct(int x, int y) {
        return x * y;
    }

    protected override int CalculateSum(int x, int y) {
        return x + y;
    }
}

abstract class SelectiveImpl : BaseCalculator {

    protected sealed override int CalculateProduct(int x, int y) {
        return x * y;
    }
}

class FinalCalculator : SelectiveImpl {

    protected override int CalculateSum(int x, int y) {
        return x + y;
    }
}

class Listing_61 {

    static void Main(string[] args) {

        // create an new CalcImpl
        BaseCalculator calc = new CalcImpl();

        // perform some calculations
        int result1 = calc.PerformCalculation(10, 20, true);
        int result2 = calc.PerformCalculation(10, 20, false);

        // print out the results
        Console.WriteLine("Result1: {0}", result1);
        Console.WriteLine("Result2: {0}", result2);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
