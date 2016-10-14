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

class Calculator : IProductCalculator, ISumCalculator, ISubtractionCalculator {

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


class Listing_11 {

    static void Main(string[] args) {


        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
