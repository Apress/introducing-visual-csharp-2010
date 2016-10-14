using System;

class Calculator {

    public int CalculateSum(int x, int y) {
        return x + y;
    }
}

class ReturnTest {

    static void Main(string[] args) {

        Calculator calc = new Calculator();

        int result = calc.CalculateSum(10, 10);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
