using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Listing_32 {

    static void Main(string[] args) {

        int[] dataValues = new int[] { 10, 20, 30, 40, 50, 60};

        // use the Average method
        double aveResult = dataValues
                            .Where(e => e > 10)
                            .Average();

        // use the Count method
        int countResult = dataValues
                            .Where(e => e > 10)
                            .Count();

        // use the Max and Min methods
        int maxResult = dataValues.Where(e => e > 10).Max();
        int minResult = dataValues.Where(e => e > 10).Min();

        // use the Sum method
        int sumResult = dataValues.Where(e => e > 10).Sum();

        // print out the results
        Console.WriteLine("Average: {0}", aveResult);
        Console.WriteLine("Count: {0}", countResult);
        Console.WriteLine("Max: {0}", maxResult);
        Console.WriteLine("Min: {0}", minResult);
        Console.WriteLine("Sum: {0}", sumResult);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}