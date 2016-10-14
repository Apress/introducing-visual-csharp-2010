using System;

class Calculator {

    public int PerformCalculation(bool calcProduct, int x, int y) {

        if (calcProduct) {
            return x * y;
        } else {
            return x + y;
        }
    }
}

class Listing_23 {

    static void Main(string[] args) {

        Calculator calc = new Calculator();

        int product = calc.PerformCalculation(true, 10, 10);
        int sum = calc.PerformCalculation(false, 10, 10);

        Console.WriteLine("Product: {0}, Sum: {1}", product, sum);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}