using System;

public interface IBasicCalculator {

    event EventHandler<EventArgs> CalculationPerformedEvent;
    
    int CalculateSum(int x, int y);
}

class Calculator : IBasicCalculator {

    public event EventHandler<EventArgs> CalculationPerformedEvent;

    public int CalculateSum(int x, int y) {
        // calculate the result
        int result = x + y;
        // invoke the event
        CalculationPerformedEvent(this, EventArgs.Empty);
        // return the result
        return result;
    }
}

class Listing_05 {

    static void Main() {

        // create a new Calculator object and cast it to the interface type
        IBasicCalculator calc = new Calculator();

        // use a lambda expression to listen to events from the calc
        calc.CalculationPerformedEvent += (source, args) => {
            Console.WriteLine("Calculation Performed Event Received");
        };

        // perform a calculation and print the results to the console
        int result = calc.CalculateSum(100, 50);
        Console.WriteLine("Result: {0}", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}