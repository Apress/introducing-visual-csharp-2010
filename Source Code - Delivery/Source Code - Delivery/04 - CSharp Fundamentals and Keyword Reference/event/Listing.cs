using System;

class Calculator {
    public event EventHandler<EventArgs> CalculationPerformedEvent;

    public int CalculateProduct(int x, int y) {
        // calculate the result
        int result = x * y;
        // send an event
        CalculationPerformedEvent(this, EventArgs.Empty);
        // return the result
        return result;
    }

}

class EventTest {

    static void Main() {

        // create a Calculator object
        Calculator calc = new Calculator();

        // subscribe to the event using a lamba expression
        calc.CalculationPerformedEvent += ((object source, EventArgs args) => {
            Console.WriteLine("Event received");
        });

        // perform a calculation
        calc.CalculateProduct(10, 10);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
