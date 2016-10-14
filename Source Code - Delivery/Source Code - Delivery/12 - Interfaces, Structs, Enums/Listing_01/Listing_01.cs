using System;

public interface IBasicCalculator {

    int CalculateSum(int x, int y);

    int CalculateProduct(int x, int y);

}

class Calculator : IBasicCalculator {


    public int CalculateSum(int x, int y) {
        return x + y;
    }

    public int CalculateProduct(int x, int y) {
        return x * y;
    }
}


class Listing_03 {

    static void Main(string[] args) {

        // create an object and upcast it to the interface type
        IBasicCalculator calc = new Calculator();

        // perform some calculations using the interface members
        int sumresult = calc.CalculateSum(100, 100);
        int productresult = calc.CalculateProduct(100, 100);

        // print out the results
        Console.WriteLine("Sum Result: {0}", sumresult);
        Console.WriteLine("Product Result: {0}", productresult);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
