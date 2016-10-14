using System;

class Calculator {

    public int CalculateSum(int x, int y) {
        return x + y;
    }

    public T GreatestValue<T>(T left, T right) where T : IComparable<T> {
        if (left.CompareTo(right) <= 0) {
            return right;
        } else {
            return left;
        }
    }
}

class Listing_12 {

    static void Main(string[] args) {

        // create a new instance of Calculator
        Calculator calc = new Calculator();

        // use the non-generic method
        int result = calc.CalculateSum(10, 20);
        Console.WriteLine("Result: {0}", result);

        // call the generic method with int values
        int biggestInt = calc.GreatestValue<int>(20, 30);
        Console.WriteLine("Biggest: {0}", biggestInt);

        // call the generic method with string values
        string biggestString = calc.GreatestValue<string>("Hello", "World");
        Console.WriteLine("Biggest: {0}", biggestString);

        // call the generic method with int values
        int c = 20, d = 30;
        result = calc.GreatestValue(c, d);


        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
