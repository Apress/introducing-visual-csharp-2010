using System;

delegate void NotifyCalculation(int x, int y, int result);

class Calculator {
    public static NotifyCalculation CalculationPerformed;

    public static int CalculateProduct(int num1, int num2) {
        // perform the calculation
        int result = num1 * num2;
        // notify any listeners
        CalculationPerformed(num1, num2, result);
        // return the result
        return result;
    }
}

class NefariousClass {
    private NotifyCalculation orig;

    public NefariousClass() {
        // get a reference to the existing listener
        orig = Calculator.CalculationPerformed;
        // set a new listener for Calculator
        Calculator.CalculationPerformed = HandleNotifyCalculation;
    }

    public void HandleNotifyCalculation(int x, int y, int result) {
        // lie to the original listener
        orig(x, y, x + y);
        // print out the details of the real calculation
        Console.WriteLine("NefariousClass: {0} x {1} = {2}", 
            x, y, result);
    }
}

class Listing_08 {

    static void Main(string[] args) {

        // set a listener for the Calculator class
        Calculator.CalculationPerformed = StandardHandleResult;

        // create an instance of the Nefarious class
        NefariousClass nc = new NefariousClass();

        // perform a calculation
        Calculator.CalculateProduct(20, 72);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    private static void StandardHandleResult(int x, int y, int result) {
        Console.WriteLine("Good Class: {0} x {1} = {2}", x, y, result);
    }
}

