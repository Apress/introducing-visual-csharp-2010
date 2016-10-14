using System;

class Calculator {

    public void PerformCalculation(int firstValue, 
            int secondValue, 
            out int sumResult, 
            out int productResult) {

        // calculator the sum
        int sum = firstValue + secondValue;
        // calculate the product
        int product = firstValue * secondValue;
        // pass the results back via the out parameters
        sumResult = sum;
        productResult = product;
    }


    //public struct CalculationResult {
    //    public int SumResult;
    //    public int ProductResult;
    //}

    //public CalculationResult PerformCalculation(int firstValue, int secondValue) {
    //    // calculator the sum
    //    int sum = firstValue + secondValue;
    //    // calculate the product
    //    int product = firstValue * secondValue;

    //    // pass the results back via the struct
    //    return new CalculationResult() {
    //        SumResult = sum,
    //        ProductResult = product
    //    };
    //}

    public Tuple<int, int> PerformCalculation(int firstValue, int secondValue) {
        // calculator the sum
        int sum = firstValue + secondValue;
        // calculate the product
        int product = firstValue * secondValue;

        // create and return a tuple<T, T> to contain the result
        return Tuple.Create(sum, product);
    }
}

class Listing_02 {

    static void Main(string[] args) {

        // define the variables that the result will be assigned to
        int sum, product;

        // perform the calculations
        new Calculator().PerformCalculation(10, 20, out sum, out product);

        // print out the results
        Console.WriteLine("Sum result: {0}, Product result: {1}",
            sum, product);

        //// do the same thing for the struct approach
        //Calculator.CalculationResult result = new Calculator().PerformCalculation(10, 20);
        //Console.WriteLine("Sum result: {0}, Product result: {1}", result.SumResult, result.ProductResult);

        Tuple<int, int> result = new Calculator().PerformCalculation(10, 20);
        Console.WriteLine("Sum result: {0}, Product result: {1}", result.Item1, result.Item2);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
