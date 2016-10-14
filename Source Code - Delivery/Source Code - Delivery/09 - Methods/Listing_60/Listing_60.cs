using System;

partial class Calculator {

    partial void ValidateNumbers(int x, int y);
    partial void ValidateResult(int result);

    public int PerformCalculation(int x, int y) {
        // call the validation partial method
        ValidateNumbers(x, y);
        // perform the calculation
        int result = x * y;
        // call the validation partial method
        ValidateResult(result);
        // return the result
        return result;
    }
}

partial class Calculator {

    partial void ValidateNumbers(int x, int y) {
        Console.WriteLine("ValidateNumbers: {0}, {1}", x, y);
    }
}

partial class Calculator {

    partial void ValidateResult(int result) {
        Console.WriteLine("Validate Result: {0}", result);
    }
}

class Listing_60 {

    static void Main(string[] args) {

        // create a new instance of Calculator
        Calculator calc = new Calculator();

        // perform a calculation
        int result = calc.PerformCalculation(10, 20);

        // print out the result
        Console.WriteLine("Result: {0}", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}