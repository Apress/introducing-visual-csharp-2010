using System;

public static class Calculator {

    public static int CalculateSum(int x, int y) {
        return x + y;
    }

    public static int CalculateProduct(int x, int y) {
        return x * y;
    }
}

class Listing_28 {

    static void Main(string[] args) {

        // call the methods of the static class
        int result1 = Calculator.CalculateSum(10, 120);
        int result2 = Calculator.CalculateProduct(10, 120);

        // print out the results
        Console.WriteLine("Sum Result: {0}", result1);
        Console.WriteLine("Product Result: {0}", result2);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
