using System;

abstract class MyAbstractClass {

    public abstract int CalculateProduct(int x, int y);
}

class Calculator : MyAbstractClass {

    public override int CalculateProduct(int x, int y) {
        return x * y;
    }
}

class AbstractTest {

    static void Main(string[] args) {


        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
