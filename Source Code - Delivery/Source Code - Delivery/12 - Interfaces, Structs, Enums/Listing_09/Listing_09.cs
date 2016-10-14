using System;

partial interface ICalculator {

    int CalculateProduct(int x, int y);
}

partial interface ICalculator {

    int CalculateSum(int x, int y);
}

class CalculatorImpl : ICalculator {

    public int CalculateProduct(int x, int y) {
        return x * y;
    }

    public int CalculateSum(int x, int y) {
        return x + y;
    }
}

class Listing_09 {

        static void Main(string[] args) {


            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
