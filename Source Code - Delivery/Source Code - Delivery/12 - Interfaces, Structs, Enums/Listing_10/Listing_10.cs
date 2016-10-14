using System;

interface ICalculator {

    int CalculateSum(int x, int y);
}

class BaseCalculator {

    public virtual int CalculateProduct(int x, int y) {
        return x * y;
    }
}

class DerivedCalculator : BaseCalculator, ICalculator {

    public int CalculateSum(int x, int y) {
        return x + y;
    }
}



class Listing_10 {

    static void Main(string[] args) {

        // create an instance of the derived class
        DerivedCalculator calc = new DerivedCalculator();

        // upcast to the interface type
        ICalculator icalc = calc;

        // upcast to the base type
        BaseCalculator bcalc = calc;
        
        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
