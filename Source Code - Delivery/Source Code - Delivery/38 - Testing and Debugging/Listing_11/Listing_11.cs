using System.Diagnostics.Contracts;

class Calculator {

    public int CalculateSum(int x, int y) {
        return x + y;
    }

    public int CalculateProduct(int x, int y) {
        return x * y;
    }

    public int CalculateSubtraction(int x, int y) {
        return x - y;
    }

    public int CalculateDivision(int x, int y) {
        Contract.Requires(y != 0, "Second parameter is zero");
        return x / y;
    }
}

class CalculatorTest {

    static void Main() {

        //// create a new Calculator object
        //Calculator calc = new Calculator();

        //// perform some calculations
        //int sumResult = calc.CalculateProduct(10, 20);
        //int productResult = calc.CalculateSum(10, 20);
        //int subtractionResult = calc.CalculateSubtraction(10, 20);
        //int divisionResult = calc.CalculateDivision(10, 20);

        //// write out the results
        //Console.WriteLine("Sum Result: {0}", sumResult);
        //Console.WriteLine("Product Result: {0}", productResult);
        //Console.WriteLine("Subtraction Result: {0}", subtractionResult);
        //Console.WriteLine("Division Result: {0}", divisionResult);

        //// wait for input before exiting
        //Console.WriteLine("Press enter to finish");
        //Console.ReadLine();
    }
}