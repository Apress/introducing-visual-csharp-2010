using System;

class Calculator {

    public void CalculateSum(ref int result, int x, int y) {
        result = x + y;
    }
}

class RefTest {

    static void Main(string[] args) {

        // create a Calculator object
        Calculator calc = new Calculator();
        // define a value-type variable that will be used as the ref parameter
        int result = 0;
        // call the CalculateSum method
        calc.CalculateSum(ref result, 10, 10);
        // print the result
        Console.WriteLine("Result: {0}", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}