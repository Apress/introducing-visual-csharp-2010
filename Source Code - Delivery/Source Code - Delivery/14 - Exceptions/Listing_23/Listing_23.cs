using System;
using System.Collections.Generic;

class Calculator {

    public static int PerformCalculation(int param1, int param2, object context) {
        
        // define a collection to store exceptions
        List<Exception> list = new List<Exception>();

        // check the parameters
        if (param1 < 1) {
            list.Add(new ArgumentOutOfRangeException("param1", param1, "Param1 is out of range"));
        }
        if (param2 < 1) {
            list.Add(new ArgumentOutOfRangeException("param2", param2, "Param2 is out of range"));
        }
        if (context == null) {
            list.Add(new NullReferenceException("Context parameter is null"));
        }

        // check to see if we have any exceptions
        if (list.Count > 0) {
            throw new AggregateException(list);
        } else {
            // perform the calculation and return the result
            return param1 * param2;
        }
    }

}

class Listing_23 {

    static void Main(string[] args) {

        try {

            // call the PerformCalculation method to cause all of
            // the indivual exceptions to be aggregated
            Calculator.PerformCalculation(-1, -1, null);

        } catch (AggregateException ex) {

            // get the aggregated exceptions
            foreach (Exception e in ex.InnerExceptions) {
                Console.WriteLine("--- Aggregated Exception ---");
                Console.WriteLine("Type: {0}", e.GetType());
                Console.WriteLine("Message: {0}", e.Message);
            }
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
