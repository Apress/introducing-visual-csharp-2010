using System;

delegate int PerformCalc(int x, int y);

class Calculator {

    public int CalculateSum(int x, int y) {
        return x + y;
    }
}

class AlternateCalculator {

    public int CalculateProduct(int x, int y) {
        return x * y;
    }
}

class Listing_07 {

    static void Main(string[] args) {

        // create a delegate variable
        PerformCalc del = new Calculator().CalculateSum;

        // combine with another method
        del += new AlternateCalculator().CalculateProduct;

        // Interrogate the delegate
        Delegate[] inlist = del.GetInvocationList();
        foreach (Delegate d in inlist) {
            Console.WriteLine("Target: {0}", d.Target);
            Console.WriteLine("Method: {0}", d.Method);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

