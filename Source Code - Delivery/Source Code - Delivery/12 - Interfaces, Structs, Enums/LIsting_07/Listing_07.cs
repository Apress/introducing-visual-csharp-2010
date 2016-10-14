using System;

interface IBaseCalculator {

    int CalculateSum(int x, int y);
}

interface IDerivedCalculator : IBaseCalculator {

    int CalculateProduct(int x, int y);
}

class Calculator : IDerivedCalculator {

    public int CalculateProduct(int x, int y) {
        return x * y;
    }

    public int CalculateSum(int x, int y) {
        return x + y;
    }
}


class Listing_07 {

    static void Main(string[] args) {

        // create an instance of Calculator and upcast it
        IDerivedCalculator derivedCalc = new Calculator();
        // upcast the derived interface to the base interface
        IBaseCalculator baseCalc = derivedCalc;

        // perform some calculations using the upcast variables
        int sumResult = baseCalc.CalculateSum(10, 10);
        int productResult = derivedCalc.CalculateProduct(10, 10);
        // write out the results
        Console.WriteLine("Sum Result: {0}", sumResult);
        Console.WriteLine("Product Result: {0}", productResult);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
