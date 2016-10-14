using System;

class Calculator {
    public static int Multiplier;

    static Calculator() {
        Console.WriteLine("Static constructor called");
        Multiplier = 2;
    }

    public Calculator() {
        Console.WriteLine("Instance constructor called");
    }

    public int PerformCalculation(int x, int y) {
        return x * y * Multiplier;
    }
}

class Listing_53 {

    static void Main(string[] args) {

        // create 5 instances of Calculator
        for (int i = 0; i < 5; i++) {
            Calculator calc = new Calculator();
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
