﻿using System;

class Calculator {
    private int[,] resultsData;

    public Calculator() {
        // initialize and populate the results data
        resultsData = new int[10, 10];
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                resultsData[i, j] = i * j;
            }
        }
    }

    public int PerformCalculation(int num1, int num2) {
        return resultsData[num1, num2];
    }
}

class Listing_19 {

    static void Main(string[] args) {

        // create a new instance of the Calculator class
        Calculator calc = new Calculator();

        try {

            // make a call to the Calculator.PerformCalculation method
            // which we know will cause an exception
            calc.PerformCalculation(100, 10);

        } catch (Exception ex) {
            Console.WriteLine("Handled exception of type: {0}", ex.GetType());
            Console.WriteLine(ex.ToString());
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
