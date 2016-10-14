using System;

interface ICalculator {

    int CalculateSum(int x, int y);
    int CalculateProduct(int x, int y);
}

abstract class AbstractCalculator : ICalculator {


    public abstract int CalculateSum(int x, int y);
        

    public int CalculateProduct(int x, int y) {
        return x * y;
    }
}

class Calculator : AbstractCalculator {

    public override int CalculateSum(int x, int y) {
        return x + y;
    }
}


class Listing_15 {

    static void Main(string[] args) {


        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
