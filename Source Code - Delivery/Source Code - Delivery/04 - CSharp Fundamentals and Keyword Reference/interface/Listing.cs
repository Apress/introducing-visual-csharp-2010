using System;

public interface ICalc {

    int CalculateProduct(int x, int y);
}

public class Calculator : ICalc {

    public int CalculateProduct(int x, int y) {
        return x * y;
    }
}

class InterfaceTest {

    static void Main(string[] args) {

        // create a new Calculator object and upcast it to the
        // interface that it implements
        ICalc calc = new Calculator();

        // call a method through the interface
        int result = calc.CalculateProduct(10, 10);

        // print out the result
        Console.WriteLine("Result: {0}", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
