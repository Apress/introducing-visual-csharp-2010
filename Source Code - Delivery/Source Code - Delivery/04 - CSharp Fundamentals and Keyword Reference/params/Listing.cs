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

class ParamsTest {

    static void Main(string[] args) {

        // create a Calculator object
        Calculator calc = new Calculator();
        // call the CalculateSum method
        int result1 = calc.CalculateSum(2, 4, 6, 8, 10);
        int result2 = calc.CalculateSum(1, 3, 5, 7);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
