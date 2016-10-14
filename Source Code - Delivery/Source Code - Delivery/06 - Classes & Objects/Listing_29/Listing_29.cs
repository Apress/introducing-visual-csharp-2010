using System;

abstract class AbstractCalculator {

    public abstract int CalculateSum(int x, int y);

    public abstract int CalculateProduct(int x, int y);
}

class CalculatorImplementation : AbstractCalculator {

    public override int CalculateSum(int x, int y) {
        return x + y;
    }

    public override int CalculateProduct(int x, int y) {
        return x * y;
    }
}

class Listing_29 {

        static void Main(string[] args) {

            // create an instance of the derived class
            // and upcast it to the abstract type
            AbstractCalculator calc = new CalculatorImplementation();

            // call the methods defined in the abstract class
            int result1 = calc.CalculateSum(100, 120);
            int result2 = calc.CalculateProduct(100, 120);

            // print out the results
            Console.WriteLine("Sum Result: {0}", result1);
            Console.WriteLine("Product Result: {0}", result2);

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
