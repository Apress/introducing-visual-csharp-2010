using System;

class Listing_14 {

    static void Main(string[] args) {

        // perform some calculations
        int sumResult = CalculateSum(10, 20);
        Console.WriteLine("Sum result: {0}", sumResult);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    public static int CalculateSum(int firstValue, int secondValue) {
#if DEBUG
        PrintOutCalculationDetails("sum", firstValue, secondValue);
#endif
        return firstValue + secondValue;
    }

    private static void PrintOutCalculationDetails(string calcType, params int[] values) {
        Console.Write("Calculation type: {0} ", calcType);
        foreach (int value in values) {
            Console.Write("{0} ", value);
        }
        Console.WriteLine();
    }

}