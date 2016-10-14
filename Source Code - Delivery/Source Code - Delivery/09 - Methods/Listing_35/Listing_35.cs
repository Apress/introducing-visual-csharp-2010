using System;

class Calculator {

    public virtual int CalculateSum(int x, int y) {
        return x + y;
    }
}

class DoubleResultCalc : Calculator {

    public override int CalculateSum(int x, int y) {
        // call the base implementation of this method
        int interimResult = base.CalculateSum(x, y);
        // return twice the result we got from the base class
        return interimResult * 2;
    }
}

class Listing_35 {

    static void Main(string[] args) {

        // create a new instance of the derived class
        DoubleResultCalc dc = new DoubleResultCalc();

        // perform a calculation
        int result = dc.CalculateSum(10, 10);

        // print the result
        Console.WriteLine("Result: {0}", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}