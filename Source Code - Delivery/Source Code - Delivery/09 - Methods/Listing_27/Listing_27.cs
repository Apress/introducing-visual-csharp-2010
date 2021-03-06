﻿using System;

abstract class AbstractCalculator {

    public abstract int CalculateSum(int x, int y);

    public abstract int CalculateProduct(int x, int y);

}

class Calculator : AbstractCalculator {

    public override int CalculateSum(int x, int y) {
        return x + y;
    }

    public override int CalculateProduct(int x, int y) {
        return x * y;
    }
}

class Listing_27 {

    static void Main(string[] args) {


        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
