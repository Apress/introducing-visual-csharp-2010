using System;

public interface IBasicCalculator {

    int CalculationsPerformedCounter { get; set; }

    int CalculateSum(int x, int y);

    int CalculateProduct(int x, int y);

}

public class Calculator : IBasicCalculator {
    private int calcCounter = 0;

    public int CalculationsPerformedCounter {
        get {
            return calcCounter;
        }
        set {
            calcCounter = value;
        }
    }

    public int CalculateSum(int x, int y) {
        // increment the calculation counter
        CalculationsPerformedCounter++;
        // perofrm the calculation and return the result
        return x + y;
    }

    public int CalculateProduct(int x, int y) {
        // increment the calculation counter
        CalculationsPerformedCounter++;
        // perform the calculation and return the result
        return x * y;
    }
}


class Listing_04 {

    static void Main(string[] args) {

        // create an object and upcast it to the interface type
        IBasicCalculator calc = new Calculator();

        // perform some calculations using the interface members
        int sumresult = calc.CalculateSum(100, 100);
        int productresult = calc.CalculateProduct(100, 100);

        // print out the results
        Console.WriteLine("Sum Result: {0}", sumresult);
        Console.WriteLine("Product Result: {0}", productresult);

        // print out the number of calculations that have been performed
        Console.WriteLine("Calculations Counter: {0}", calc.CalculationsPerformedCounter);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
