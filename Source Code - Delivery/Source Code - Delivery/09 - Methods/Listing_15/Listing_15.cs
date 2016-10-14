using System;

class Calculator {

    public int CalculateSum(params int[] numbers) {
        int result = 0;
        foreach (int i in numbers) {
            result += i;
        }
        return result;
    }
}

class Listing_16 {

    static void Main(string[] args) {

        // create a new instance of Calculator
        Calculator calc = new Calculator();

        // create an array of int values and pass them
        // as a parameter to the CalculateSum method
        int[] data = { 10, 34, 54, 124, 23 };
        int result = calc.CalculateSum(data);
        Console.WriteLine("First result: {0}", result);

        // call the CalculateSum method with one argument
        result = calc.CalculateSum(10);
        Console.WriteLine("Second result: {0}", result);

        // call with two arguments
        result = calc.CalculateSum(10, 34);
        Console.WriteLine("Third result: {0}", result);

        // call with the same values that were in the array
        result = calc.CalculateSum(10, 34, 54, 124, 23);
        Console.WriteLine("Fourth result: {0}", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}