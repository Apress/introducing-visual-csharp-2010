using System;

delegate void NotifyCalculation(int x, int y, int result);

class Calculator {
    NotifyCalculation calcListener;

    public Calculator(NotifyCalculation listener) {
        calcListener = listener;
    }

    public int CalculateProduct(int num1, int num2) {
        // perform the calculation
        int result = num1 * num2;
        // notify the delegate that we have performed a calc
        calcListener(num1, num2, result);
        // return the result
        return result;
    }
}

class CalculationListener {
    public static void CalculationPrinter(int x, int y, int result) {
        Console.WriteLine("Calculation Notification: {0} x {1} = {2}", 
            x, y, result);
    }
}

class Listing_04 {

    static void Main(string[] args) {

        // create a new Calculator, passing in the printer method
        Calculator calc = new Calculator(CalculationListener.CalculationPrinter);

        // perform some calculations
        calc.CalculateProduct(10, 20);
        calc.CalculateProduct(2, 3);
        calc.CalculateProduct(20, 1);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }


}