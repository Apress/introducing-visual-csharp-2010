using System;

class Calculator {

    public void CalculateSum(out int result, int x, int y) {
        result = x + y;
    }
}

class OutTest {

    static void Main(string[] args) {

        // create a Calculator object
        Calculator calc = new Calculator();
        // define a value-type variable that will be used as the ref parameter
        int result;
        // call the CalculateSum method
        calc.CalculateSum(out result, 10, 10);
        // print the result
        Console.WriteLine("Result: {0}", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
