﻿using System;
using System.Diagnostics;

class Calculator {

    public int CalculateSum(int x, int y) {
        return x + y;
    }

    public int CalculateProduct(int x, int y) {
        return x * y;
    }

    public int CalculateSubtraction(int x, int y) {
        return x - y;
    }

    public int CalculateDivision(int x, int y) {
        Trace.WriteLine("Entered CalculateDivision Method", "Trace");
        Trace.Indent();
        Trace.WriteLine(string.Format("Parameters are: {0} {1}", x, y), "Parameters");
        Trace.WriteLineIf(y == 0, "Second parameter is zero", "Error");
        Trace.Unindent();
        Trace.WriteLine("Exiting CalculateDivision Method", "Trace");
        return x / y;
    }
}

class CalculatorTest {

    static void Main(string[] args) {

        // remove the default listener
        Trace.Listeners.Clear();
        // create a new listener
        TextWriterTraceListener listener = new TextWriterTraceListener(Console.Out);
        // register our new listener
        Trace.Listeners.Add(listener);

        // create a new Calculator object
        Calculator calc = new Calculator();

        // perform a calculation that we know will cause a problem
        int divisionResult = calc.CalculateDivision(10, 0);

        // write out the result
        Console.WriteLine("Division Result: {0}", divisionResult);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}