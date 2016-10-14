using System;

interface ICalculator {

    int CalculateSum(int x, int y);

}

class BaseCalc : ICalculator {

    public virtual int CalculateSum(int x, int y) {
        return x + y;
    }
}

class DerivedCalc : BaseCalc {

    public override int CalculateSum(int x, int y) {
        return base.CalculateSum(x, y) * 2;
    }
}

class Listing_14_Test {

    static void Main(string[] args) {

        // create an instance of the derived class
        DerivedCalc calc = new DerivedCalc();

        // upcast to the base type
        BaseCalc bCalc = calc;

        // upcast the dervied type to the interface type
        ICalculator iCalc = calc;

        // call the method defined by the interface and 
        // print out the results
        int result = iCalc.CalculateSum(10, 10);
        Console.WriteLine("Result: {0}", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
