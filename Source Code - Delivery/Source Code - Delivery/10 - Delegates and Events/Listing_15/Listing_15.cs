using System;

class Calculator {
    public event EventHandler CalculationPerformedEvent;

    public int CalculateProduct(int num1, int num2) {
        // perform the calculation
        int result = num1 * num2;
        // publish the event
        OnCalculationPerformed();
        // return the result
        return result;
    }

    private void OnCalculationPerformed() {
        // make a copy of the event
        EventHandler handler = CalculationPerformedEvent;
        // check to see we have subscribers
        if (handler != null) {
            handler(this, EventArgs.Empty);
        }
    }
}

class Listing_15 {

    static void Main(string[] args) {

        // create a new instance of the Calculator class
        Calculator calc = new Calculator();

        // subscribe to the event in the calaculator class
        calc.CalculationPerformedEvent += HandleEvent;

        // perform a calculation
        calc.CalculateProduct(20, 72);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    static void HandleEvent(object sender, EventArgs e) {
        Console.WriteLine("Event Received");
    }
}