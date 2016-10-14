using System;

class Calculator {
    private int myField = 20;

    public int PerformCalculation(int x, int y) {

        // create a local variable
        int product = x * y;
        
        // create a new variable and assign it 
        // the value of the product variable
        int localVar = product;
        // assign the value of the field to the variable
        localVar = myField;

        // return the local variable
        return product;
    }
}

class Listing_20 {

    static void Main(string[] args) {

        // create a new instance of Calculator
        Calculator calc = new Calculator();

        // call the methof
        int result = calc.PerformCalculation(10, 10);

        // print out the result
        Console.WriteLine("Result: {0}", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}