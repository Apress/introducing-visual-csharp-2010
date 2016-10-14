//#define PRINT_CALC_DETAILS

using System;
using System.Diagnostics;

class Listing_15 {

    static void Main(string[] args) {

        // perform some calculations
        int sumResult = CalculateSum(10, 20);
        Console.WriteLine("Sum result: {0}", sumResult);
        int productResult = CalculateProduct(10, 20);
        Console.WriteLine("Product result: {0}", productResult);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    public static int CalculateSum(int firstValue, int secondValue) {
        PrintOutCalculationDetails("sum", firstValue, secondValue);
        return firstValue + secondValue;
    }

    public static int CalculateProduct(int firstValue, int secondValue) {
        PrintOutCalculationDetails("product", firstValue, secondValue);
        return firstValue * secondValue;
    }

    [Conditional("PRINT_CALC_DETAILS")]
    private static void PrintOutCalculationDetails(string calcType, params int[] values) {
        Console.Write("Calculation type: {0} ", calcType);
        foreach (int value in values) {
            Console.Write("{0} ", value);
        }
        Console.WriteLine();
    }
}