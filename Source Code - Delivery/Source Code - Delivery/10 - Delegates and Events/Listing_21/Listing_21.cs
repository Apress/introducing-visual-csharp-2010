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

class Listing_21 {

    static void Main(string[] args) {

        // create a new Calculator
        Calculator calc = new Calculator();

        // create a delegate with an anonymous method
        calc.CalculationPerformedEvent += delegate(object sender, CalculationEventArgs e) {
            Console.WriteLine("Anonymous Calc: {0} x {1} = {2}", e.X, e.Y, e.Result);
        };

        // perform a calculation
        calc.CalculateProduct(20, 40);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
