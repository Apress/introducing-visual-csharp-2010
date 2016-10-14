using System;

delegate void NotifyCalculation(int x, int y, int result);

class Calculator {
    NotifyCalculation calcListener;

    public void AddListener(NotifyCalculation listener) {
        calcListener += listener;
    }

    public void RemoveListener(NotifyCalculation listener) {
        calcListener -= listener;
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
    private string idString;

    public CalculationListener(string id) {
        idString = id;
    }

    public void CalculationPrinter(int x, int y, int result) {
        Console.WriteLine("{0}: Notification: {1} x {2} = {3}",
            idString, x, y, result);
    }
}

class AlternateListener {

    public static void CalculationCallback(int x, int y, int result) {
        Console.WriteLine("Callback: {0} x {1} = {2}",
            x, y, result);
    }
}

class Listing_05 {

    static void Main(string[] args) {

        // create a new Calculator
        Calculator calc = new Calculator();

        // create and add listeners
        calc.AddListener(new CalculationListener("List1").CalculationPrinter);
        calc.AddListener(new CalculationListener("List2").CalculationPrinter);
        calc.AddListener(AlternateListener.CalculationCallback);

        // perform a calculation
        calc.CalculateProduct(10, 20);

        // remove a listener
        calc.RemoveListener(AlternateListener.CalculationCallback);

        // perform a calculation
        calc.CalculateProduct(10, 30);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}