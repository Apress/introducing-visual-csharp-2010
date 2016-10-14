using System;

class CalculationEventArgs : EventArgs {
    private int x, y, result;

    public CalculationEventArgs(int num1, int num2, int resultVal) {
        x = num1;
        y = num2;
        result = resultVal;
    }

    public int X {
        get { return x; }
    }

    public int Y {
        get { return y; }
    }

    public int Result {
        get { return result; }
    }
}

class Calculator {
    public event EventHandler<CalculationEventArgs> CalculationPerformedEvent;

    public int CalculateProduct(int num1, int num2) {
        // perform the calculation
        int result = num1 * num2;
        // publish the event
        OnCalculationPerformed(new CalculationEventArgs(num1, num2, result));
        // return the result
        return result;
    }

    private void OnCalculationPerformed(CalculationEventArgs args) {
        // make a copy of the event
        EventHandler<CalculationEventArgs> handler = CalculationPerformedEvent;
        // check to see we have subscribers
        if (handler != null) {
            handler(this, args);
        }
    }
}

class Listing_12 {

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

    static void HandleEvent(object sender, CalculationEventArgs e) {
        Console.WriteLine("Good Class: {0} x {1} = {2}", e.X, e.Y, e.Result);
    }
}