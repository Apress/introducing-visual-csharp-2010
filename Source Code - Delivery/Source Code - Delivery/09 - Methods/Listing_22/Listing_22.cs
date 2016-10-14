using System;

class Calculator {

    public void PerformCalculation(int x, int y) {
        try {
            int result = x * y;
            Console.WriteLine("Result: {0}", result);
        } catch (Exception) {
            // handle exception...
        }
    }
}

class Listing_22 {

    static void Main(string[] args) {


        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}