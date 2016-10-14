using System;

interface ISumCalculator {

    int PerformCalculation(int x, int y);

}

interface IProductCalculator {

    int PerformCalculation(int x, int y);

}

class Calculator : ISumCalculator, IProductCalculator {


    int ISumCalculator.PerformCalculation(int x, int y) {
        Console.WriteLine("ISumCalculator.PerformCalculation was called");
        return x + y;
    }

    int IProductCalculator.PerformCalculation(int x, int y) {
        Console.WriteLine("IProductCalculator.PerformCalculation was called");
        return x * y;
    }
}

class Listing_13_Test {

    static void Main(string[] args) {

        // create an instance of the Calculator object
        Calculator calc = new Calculator();

        // upcast to IProductCalculator and call the method
        IProductCalculator pcalc = calc;
        int productResult = pcalc.PerformCalculation(10, 10);

        // upcast to ISumCalculator and call the method
        ISumCalculator scalc = calc;
        int sumResult = scalc.PerformCalculation(10, 10);

        // print the result
        Console.WriteLine("Product result: {0}", productResult);
        Console.WriteLine("Sum Result: {0}", sumResult);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
