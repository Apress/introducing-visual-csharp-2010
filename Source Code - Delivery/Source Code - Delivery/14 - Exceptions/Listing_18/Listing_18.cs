using System;

class CalculationException : Exception {
    private int param1, param2;

    public CalculationException()
        : base() {
    }

    public CalculationException(string message)
        : base(message) {
    }

    public CalculationException(string message, Exception inner)
        : base(message, inner) {
    }

    public CalculationException(string message, int p1, int p2)
        : base(message) {
            param1 = p1;
            param2 = p2;
    }

    public int Param1 {
        get { return param1; }
    }

    public int Param2 {
        get { return param2; }
    }
}

class Calculator {

    public static int PerformCalculation(int param1, int param2) {
        if (param1 > 0 && param2 > 0) {
            // perform the calculation and return the results
            return param1 * param2;
        } else {
            // one or more of the params are a problem
            throw new CalculationException("One of parameters is too small", param1, param2);
        }
    }
}

class Listing_18 {

    static void Main(string[] args) {

        try {

            // perform a calculation that we know will cause an exception
            Calculator.PerformCalculation(0, 100);

        } catch (CalculationException ex) {
            Console.WriteLine("Caught exception of type: {0}", ex.GetType());
            Console.WriteLine("Message: {0}", ex.Message);
            Console.WriteLine("Param1: {0}", ex.Param1);
            Console.WriteLine("Param2: {0}", ex.Param2);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

