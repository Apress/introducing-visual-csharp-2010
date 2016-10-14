using System;

public partial class Calculator {

    public int CalculateProduct(int x, int y) {
        return x * y;
    }
}

public partial class Calculator {

    public int CalculateSum(int x, int y) {
        return x + y;
    }
}

class Listing_32_Test {

    static void Main(string[] args) {

        // create an instance of the sealed class
        Calculator calc = new Calculator();

        // call the methods of the sealed class
        int result1 = calc.CalculateSum(10, 120);
        int result2 = calc.CalculateProduct(10, 120);

        // print out the results
        Console.WriteLine("Sum Result: {0}", result1);
        Console.WriteLine("Product Result: {0}", result2);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
