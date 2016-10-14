using System;

class Calculator {

    public virtual int CalculateSum(int x, int y) {
        return x + y;
    }

    public virtual int CalculateProduct(int x, int y) {
        return x * y;
    }
}

class DerivedCalc : Calculator {

    public sealed override int CalculateSum(int x, int y) {
        // more specialized implementation of method action/calculation
        return 0;
    }

    public override int CalculateProduct(int x, int y) {
        // more specialized implementation of method action/calculation
        return 0;
    }
}

class Listing_26 {

    static void Main(string[] args) {


        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}