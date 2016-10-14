using System;

class Calculator {

    public static int PerformCalculation(int x, int y) {
        return x * y;
    }
}
    
class Listing_24 {

    static void Main(string[] args) {

        // perform a calculation using the static method
        int result = Calculator.PerformCalculation(10, 10);

        Console.WriteLine("Result: {0}", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}