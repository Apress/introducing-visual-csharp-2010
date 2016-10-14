using System;

interface IProductCalculator {

    int CalculateProduct(int x, int y);
}

interface ISumCalculator {

    int CalculateSum(int x, int y);
}

interface ISubtractionCalculator {

    int CalculateSubtraction(int x, int y);

}

interface ICombinedCalculator : IProductCalculator, ISumCalculator, ISubtractionCalculator {

    int CalculateDivision(int x, int y);

}

class Calculator : ICombinedCalculator {


    public int CalculateDivision(int x, int y) {
        return x / y;
    }

    public int CalculateProduct(int x, int y) {
        return x * y;
    }

    public int CalculateSum(int x, int y) {
        return x + y;
    }

    public int CalculateSubtraction(int x, int y) {
        return x - y;
    }
}

class Listing_08_Test {

    static void Main(string[] args) {

        // create an object and upcast it to the combined interface
        ICombinedCalculator calc = new Calculator();

        // upcast to the base interfaces and call the method that each defines
        IProductCalculator prodCalc = calc;
        int prodResult = prodCalc.CalculateProduct(10, 10);
        ISumCalculator sumCalc = calc;
        int calcResult = sumCalc.CalculateSum(10, 10);
        ISubtractionCalculator subCalc = calc;
        int subResult = subCalc.CalculateSubtraction(10, 2);

        // explicitly cast from one base interface to another
        prodCalc = (IProductCalculator)subCalc;


        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
