using System;

public interface IBasicCalculator {

    int this[int x, int y] { get; set; }
}

class Calculator : IBasicCalculator {

    public int this[int x, int y] {
        get {
            return x + y;
        }
        set {
            throw new NotImplementedException();
        }
    }
}

class Listing_06 {

    static void Main(string[] args) {

        // create a Calculator object and upcast it
        IBasicCalculator calc = new Calculator();

        // use the indexer to perform a calculation
        int result = calc[10, 10];
        // print out the results
        Console.WriteLine("Result: {0}", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
