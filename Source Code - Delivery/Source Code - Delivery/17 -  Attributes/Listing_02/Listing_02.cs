using System;

class Calculator {

    [Obsolete("Don't use this method", true)]
    public int CalculateProduct(int x, int y) {
        return x + y;
    }

}

class Listing_02 {

    static void Main(string[] args) {

        // create a new instance of Calculator
        Calculator calc = new Calculator();

        // call the method which has been modified with the Obsolete attribute
       // calc.CalculateProduct(10, 20);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
